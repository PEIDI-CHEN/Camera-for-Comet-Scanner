using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;

namespace TEST
{
    public partial class Form1 : Form
    {

        //[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //public delegate int PFCALLBACK(IntPtr buf, int ww, int hh);

        //[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //public delegate int STILLPHOTOCALLBACK(IntPtr Imagepath, int FileType);

        //[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        //public delegate int VIDEOPARAMCALLBACK();

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetDeviceCount();

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetDeviceName(int index, byte[] nbuf);

        //[DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        //public extern static int GetResolutionCount(int index);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetStillResolutionCount(int index);

        //[DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        //public extern static int GetResolution(int R_index, ref int width, ref int height);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int GetStillResolution(int R_index, ref int width, ref int height);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int SetResolution(int stillIndex, int previewIndex);

        //[DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        //public extern static int OpenDevice(int index, int width, int height, IntPtr mhwnd, Boolean isDisplay);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int OpenDeviceEx(int index, int width, int height, IntPtr mhwnd, Boolean isDisplay);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int CloseDevice();

        //[DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        //public extern static IntPtr CaptureFromPreview(byte[] Imagepath, int type);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int CaptureFromStill(byte[] Imagepath);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetCutType(int cutType);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetFormatType(int format);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetDpi(int type, int val);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetColorType(int type);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int ShowCameraSettingWindow();

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int RecogQrBarCode(int type, byte[] result);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetRotateAngle(int angle);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void BestSize();

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void TrueSize();

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ZoomIn();

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ZoomOut();

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void ManualFocus();

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetDelBgColor(int flag);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static void SetDelBlackEdge(int flag);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int AddImagePath(byte[] Imagepath);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int MergeImages(byte[] desPath, int direction, int sp);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int AddImageFileToPDF(byte[] Imagepath);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int CombineToPDF(byte[] desPath);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int ReadCard();

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static IntPtr GeCardInfo(int index);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int PicBoxMouseDown(int px, int py);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int PicBoxMouseUp(int px, int py);

        [DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        public extern static int PicBoxMouseMove(int px, int py);


        //[DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        //public extern static int GetVideoProcParms(int ParamID, ref int min, ref int max, ref int def, ref int current);

        //[DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        //public extern static int SetVideoProcParms(int ParamID, int val);

        //[DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        //public extern static int GetCameraCotrolParms(int ParamID, ref int min, ref int max, ref int def, ref int current, ref int flag);

        //[DllImport("DevCapture.dll", CallingConvention = CallingConvention.Cdecl)]
        //public extern static int SetCameraCotrolParms(int ParamID, int val, int flag);




        //PFCALLBACK CallBackFunc = null;     //视频流数据回调函数
        //STILLPHOTOCALLBACK StillImageCallBackFunc = null;  //拍照回调函数
        List<int> pLPreWidths = new List<int>();     
        List<int> pLPreHeights = new List<int>();    
        List<int> pLStillWidths = new List<int>();   
        List<int> pLStillHeights = new List<int>();

        //private delegate void AddImgToListDelegate(string path, int fType);
        //private delegate void RecogDelegate(byte[] result);
        bool isOpenCam = false;
        int RotateAngle = 0;

        public Form1()
        {
            InitializeComponent();
        }



        void GetDeviceInfo()
        {
            //Assembly dllx = Assembly.Load("DevCapture.dll");
            //var obj = dllx.CreateInstance("dllClass");
            //调用没有参数的方法
            //object result = obj.GetType().GetMethod("dllmethod").Invoke(obj, null);
            int devCount = GetDeviceCount();
            int iRest = -1;
            //*************************获取设备***************************
            if (devCount > 0)
            {
                byte[] namebuf = new byte[256];
                for (int i = 0; i < devCount; i++)
                {
                    iRest = GetDeviceName(i, namebuf);
                    if (iRest != 0)
                    {
                        continue;
                    }

                    int len = 0;
                    for (int j = 0; j < 256; j++)
                    {
                        if (namebuf[j] == 0)
                        {
                            len = j;
                            break;
                        }
                    }
                    string devName = Encoding.GetEncoding("gb2312").GetString(namebuf, 0, len);
                    comboBox1.Items.Add(devName);
                }
                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;

                    int xWidth = 0;
                    int xHeight = 0;
                    int tmpVal = 0;
                    int pos = 0;

                    //***************************获取预览分辨率**********************************
                    int resCount = GetStillResolutionCount(comboBox1.SelectedIndex);
                    if (resCount > 0)
                    {
                        for (int i = 0; i < resCount; i++)
                        {
                            iRest = GetStillResolution(i, ref xWidth, ref xHeight);//获取预览分辨率
                            if (iRest == 0)
                            {
                                pLPreWidths.Add(xWidth);
                                pLPreHeights.Add(xHeight);
                                string resStr = Convert.ToString(xWidth) + "*" + Convert.ToString(xHeight);
                                comboBox2.Items.Add(resStr);
                            }
                        }

                        //以最大分辨率预览
                        for (int i = 0; i < pLPreWidths.Count; i++)
                        {
                            if (pLPreWidths[i] > tmpVal)
                            {
                                tmpVal = pLPreWidths[i];
                                pos = i;
                            }
                        }
                        comboBox2.SelectedIndex = pos;
                    }


                
                }
            }
        }

        void ChangeDevice()
        {
            comboBox2.Items.Clear();

            int iRest = -1;
            int xWidth = 0;
            int xHeight = 0;
            int tmpVal = 0;
            int pos = 0;

            //***************************获取预览分辨率**********************************
            int resCount = GetStillResolutionCount(comboBox1.SelectedIndex);
            if (resCount > 0)
            {
                for (int i = 0; i < resCount; i++)
                {
                    iRest = GetStillResolution(i, ref xWidth, ref xHeight);//获取预览分辨率
                    if (iRest == 0)
                    {
                        pLPreWidths.Add(xWidth);
                        pLPreHeights.Add(xHeight);
                        string resStr = Convert.ToString(xWidth) + "*" + Convert.ToString(xHeight);
                        comboBox2.Items.Add(resStr);
                    }
                }

                //以最大分辨率预览
                for (int i = 0; i < pLPreWidths.Count; i++)
                {
                    if (pLPreWidths[i] > tmpVal)
                    {
                        tmpVal = pLPreWidths[i];
                        pos = i;
                    }
                }
                comboBox2.SelectedIndex = pos;
            }
        }

        int OpenTheCamera()
        {
            if (comboBox2.Items.Count <= 0)
                return -1;

            CloseDevice();
            string resStr = comboBox2.SelectedItem.ToString();
            int pos = resStr.LastIndexOf('*');
            int openWidth = Convert.ToInt32(resStr.Substring(0, pos));
            int openHeight = Convert.ToInt32(resStr.Substring(pos + 1, resStr.Length - pos - 1));



            int iRest = OpenDeviceEx(comboBox1.SelectedIndex, openWidth, openHeight, pictureBox1.Handle, true);
            if (iRest != 0)
            {
                MessageBox.Show("打开摄像头失败！");
            }
            else 
            {
                isOpenCam = true;
                //GetVideoParameter();         
            }

            return 0;
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseDevice();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox3.SelectedIndex = 1;
            GetDeviceInfo();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ChangeDevice();
            OpenTheCamera();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OpenTheCamera();
        }

        private void comboBox3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OpenTheCamera();
        }

        //设置图片格式
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFormatType(comboBox4.SelectedIndex);
        }

        //设置色彩模式
        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetColorType(comboBox5.SelectedIndex);
        }

        //设置裁切模式
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SetCutType(0);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                SetCutType(1);
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                SetCutType(2);
            }
        }

        //设置DPI
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valueStr = comboBox3.SelectedItem.ToString();
            SetDpi(1, Convert.ToInt32(valueStr));
        }

        //去底色
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                SetDelBgColor(1);
            else
                SetDelBgColor(0);
        }

        //去黑边
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
                SetDelBlackEdge(1);
            else
                SetDelBlackEdge(0);
        }


        //打开设备
        private void button1_Click(object sender, EventArgs e)
        {
            OpenTheCamera();
        }

        //关闭设备
        private void button2_Click(object sender, EventArgs e)
        {
            CloseDevice();
            isOpenCam = false;
        }

        //拍照
        private void button3_Click(object sender, EventArgs e)
        {
            int FileType = comboBox4.SelectedIndex;
            string fFormatStr = ".jpg";
            if (FileType == 0) fFormatStr = ".jpg";
            if (FileType == 1) fFormatStr = ".bmp";
            if (FileType == 2) fFormatStr = ".png";
            if (FileType == 3) fFormatStr = ".tif";
            if (FileType == 4) fFormatStr = ".pdf";
            string ImgName = DateTime.Now.ToString("yyyyMMddhhmmssfff");
            string imgpath = "D:\\" + ImgName + fFormatStr;

            byte[] pBuf = Encoding.GetEncoding("gb2312").GetBytes(imgpath);
            int iRest = CaptureFromStill(pBuf);
            if (iRest != 0)
            {
                MessageBox.Show("拍照失败！");
                return;
            }

            //在图像列表中显示
            if (File.Exists(imgpath))
            {
                int p = imgpath.LastIndexOf("\\");
                string fName = imgpath.Substring(p + 1, imgpath.Length - p - 1);
                string previewImgPath = imgpath;
                if (comboBox4.SelectedIndex == 4)
                    previewImgPath = Directory.GetCurrentDirectory() + "\\PdfLogo.png";
                this.imageList1.Images.Add(CreateImageSourceThumbnia(previewImgPath, 100, 75));
                this.listView1.Items.Add(fName, listView1.Items.Count);
                listView1.Items[listView1.Items.Count - 1].EnsureVisible();
            }

        }


        //左旋
        private void button4_Click(object sender, EventArgs e)
        {
            RotateAngle--;
            if (RotateAngle < 0)
                RotateAngle = 3;
            SetRotateAngle(RotateAngle);
        }

        //右旋
        private void button5_Click(object sender, EventArgs e)
        {            
            RotateAngle++;
            if (RotateAngle > 3)
                RotateAngle = 0;
            SetRotateAngle(RotateAngle);
        }

        //放大
        private void button6_Click(object sender, EventArgs e)
        {
            ZoomIn();
        }

        //缩小
        private void button7_Click(object sender, EventArgs e)
        {
            ZoomOut();
        }

        //适合大小
        private void button8_Click(object sender, EventArgs e)
        {
            BestSize();
        }

        //1：1
        private void button9_Click(object sender, EventArgs e)
        {
            TrueSize();
        }

        //对焦
        private void button15_Click(object sender, EventArgs e)
        {
            ManualFocus();
        }

        //硬件参数设置
        private void button14_Click(object sender, EventArgs e)
        {
            ShowCameraSettingWindow();
        }

        //条码识别
        private void button10_Click(object sender, EventArgs e)
        {
            byte[] code = new byte[512];
            RecogQrBarCode(0, code);
            string contentStr = Encoding.GetEncoding("gb2312").GetString(code);
            if (contentStr != "")
            {
                MessageBox.Show("条码结果：" + contentStr);
            }
            else 
            {
                MessageBox.Show("未识别到条码");
            }
        
        }
        //二维码识别
        private void button11_Click(object sender, EventArgs e)
        {
            byte[] code = new byte[512];
            RecogQrBarCode(1, code);
            string contentStr = Encoding.GetEncoding("gb2312").GetString(code);
            if (contentStr != "")
            {
                MessageBox.Show("二维码结果：" + contentStr);
            }
            else
            {
                MessageBox.Show("未识别到二维码");
            }
        }
        //图像合并测试
        private void button12_Click(object sender, EventArgs e)
        {
            string path1 = Directory.GetCurrentDirectory() + "\\test1.jpg";
            string path2 = Directory.GetCurrentDirectory() + "\\test2.jpg";
            AddImagePath(Encoding.GetEncoding("gb2312").GetBytes(path1));
            AddImagePath(Encoding.GetEncoding("gb2312").GetBytes(path2));
            string joinPath = Directory.GetCurrentDirectory() + "\\joinimg.jpg";
            int iRest=MergeImages(Encoding.GetEncoding("gb2312").GetBytes(joinPath),0,5); //垂直方向合并
            if (iRest == 0)
            {
                if (File.Exists(joinPath))
                {
                    int p = joinPath.LastIndexOf("\\");
                    string fName = joinPath.Substring(p + 1, joinPath.Length - p - 1);
                    string previewImgPath = joinPath;
                    if (comboBox4.SelectedIndex==4)
                        previewImgPath = Directory.GetCurrentDirectory() + "\\PdfLogo.png";
                    this.imageList1.Images.Add(CreateImageSourceThumbnia(previewImgPath, 100, 75));
                    this.listView1.Items.Add(fName, listView1.Items.Count);
                    listView1.Items[listView1.Items.Count - 1].EnsureVisible();
                }
            }

        }
        //PDF合并测试
        private void button13_Click(object sender, EventArgs e)
        {
            string path1 = Directory.GetCurrentDirectory() + "\\test1.jpg";
            string path2 = Directory.GetCurrentDirectory() + "\\test2.jpg";
            AddImageFileToPDF(Encoding.GetEncoding("gb2312").GetBytes(path1));
            AddImageFileToPDF(Encoding.GetEncoding("gb2312").GetBytes(path2));
            string pdfPath = Directory.GetCurrentDirectory() + "\\joinPdf.pdf";
            int iRest = CombineToPDF(Encoding.GetEncoding("gb2312").GetBytes(pdfPath)); //垂直方向合并
            if (iRest == 0)
            {
                if (File.Exists(pdfPath))
                {
                    int p = pdfPath.LastIndexOf("\\");
                    string fName = pdfPath.Substring(p + 1, pdfPath.Length - p - 1);
                    string previewImgPath;
                    previewImgPath = Directory.GetCurrentDirectory() + "\\PdfLogo.png";
                    this.imageList1.Images.Add(CreateImageSourceThumbnia(previewImgPath, 100, 75));
                    this.listView1.Items.Add(fName, listView1.Items.Count);
                    listView1.Items[listView1.Items.Count - 1].EnsureVisible();
                }
            }
        }


        public Bitmap CreateImageSourceThumbnia(string fileName, double width, double height)
        {
            System.Drawing.Image sourceImage = System.Drawing.Image.FromFile(fileName);
            double rw = width / sourceImage.Width;
            double rh = height / sourceImage.Height;
            var aspect = (float)Math.Min(rw, rh);
            int w = sourceImage.Width, h = sourceImage.Height;
            if (aspect < 1)
            {
                w = (int)Math.Round(sourceImage.Width * aspect); h = (int)Math.Round(sourceImage.Height * aspect);
            }
            Bitmap desBmp = new Bitmap(sourceImage, w, h);
            return desBmp;
        }

        //读取身份证
        private void button16_Click(object sender, EventArgs e)
        {
            int iRest = ReadCard();
            if (iRest != 0)
            {
                MessageBox.Show("读卡失败！");
            }
            else
            {
                IntPtr Ptr;
                Ptr = GeCardInfo(0);
                string name = Marshal.PtrToStringAnsi(Ptr);
                Ptr = GeCardInfo(1);
                string sex = Marshal.PtrToStringAnsi(Ptr);
                Ptr = GeCardInfo(2);
                string nation = Marshal.PtrToStringAnsi(Ptr);
                Ptr = GeCardInfo(3);
                string born = Marshal.PtrToStringAnsi(Ptr);
                Ptr = GeCardInfo(4);
                string address = Marshal.PtrToStringAnsi(Ptr);
                Ptr = GeCardInfo(5);
                string num = Marshal.PtrToStringAnsi(Ptr);
                Ptr = GeCardInfo(6);
                string IssuedAt = Marshal.PtrToStringAnsi(Ptr);
                Ptr = GeCardInfo(7);
                string EffectedDate = Marshal.PtrToStringAnsi(Ptr);
                Ptr = GeCardInfo(8);
                string ExpiredDate = Marshal.PtrToStringAnsi(Ptr);
                Ptr = GeCardInfo(9);
                string headImgPath = Marshal.PtrToStringAnsi(Ptr);

                string info = "姓名：" + name + "\r\n" +
                              "性别：" + sex + "\r\n" +
                              "民族：" + nation + "\r\n" +
                              "出生：" + born + "\r\n" +
                              "住址：" + address + "\r\n" +
                              "公民身份号码：" + num + "\r\n" +
                              "签证机关：" + IssuedAt + "\r\n" +
                              "有效日期：" + EffectedDate + "-" + ExpiredDate + "\r\n" +
                              "证件头像图片路径：" + headImgPath;

                MessageBox.Show(info);
            }
        }

       


       

               //############获取视频参数#################

        //private const int VideoBright = 0;
        //private const int VideoContrast = 1;
        //private const int VideoHun = 2;
        //private const int VideoSaturation = 3;
        //private const int VideoSharpness = 4;
        //private const int VideoGamma = 5;
        //private const int VideoBalance = 7;  //白平衡
        //private const int VideoBacklightCs = 8;
        //private const int VideoGain = 9;
       // private const int VideoExposure = 4;



        //public struct VideoParamObj
        //{
        //    public int Bright;   //亮度
        //    public int Contrast; //对比度
        //    public int Hun;      //色调
        //    public int Saturation; //饱和
        //    public int Sharpness;  //清晰度（锐度）
        //    public int Gamma;      //伽玛
        //    public int Balance;      //白平衡
        //    public int BacklightCs;    //逆光对比
        //    public int Gain;    //增益
        //    public int Exposure;  //曝光
        //    public int isAutoExp;
        //    public int isAutoBalance; //自动白平衡
        //}
        //public static VideoParamObj pVideoParamObj;
   

        //void GetVideoParameter()
        //{
        //    //if (global.isOpenCameraA)
        //    //{
        //    int iRest = -1;
        //    int min, max, def, current, flag;
        //    min = 0; max = 0; def = 0; current = 0; flag = 0;
        //    //亮度
        //    iRest = GetVideoProcParms(VideoBright, ref min, ref max, ref def, ref current);
        //    if (iRest == 0)
        //    {
        //        SliderBright.Minimum = min;
        //        SliderBright.Maximum = max;
        //        pVideoParamObj.Bright = current;
        //        //if (pVideoParamObj.Bright < min || pVideoParamObj.Bright > max)
        //        //    pVideoParamObj.Bright = current;
        //        SliderBright.Value = pVideoParamObj.Bright;
        //        LableBright.Text = Convert.ToString(SliderBright.Value);
        //    }

        //    //对比度
        //    iRest = GetVideoProcParms(VideoContrast, ref min, ref max, ref def, ref current);
        //    if (iRest == 0)
        //    {
        //        SliderContrast.Minimum = min;
        //        SliderContrast.Maximum = max;
        //        pVideoParamObj.Contrast = current;
        //        //if (pVideoParamObj.Contrast < min || pVideoParamObj.Contrast > max)
        //        //    pVideoParamObj.Contrast = current;
        //        SliderContrast.Value = pVideoParamObj.Contrast;
        //        LableContrast.Text = Convert.ToString(SliderContrast.Value);
        //    }

        //    //曝光度
        //    iRest = GetCameraCotrolParms(VideoExposure, ref min, ref max, ref def, ref current, ref flag);
        //    if (iRest == 0)
        //    {
        //        SliderExp.Minimum = min;
        //        SliderExp.Maximum = max;
        //        pVideoParamObj.Exposure = current;
        //        //if (pVideoParamObj.Exposure < min || pVideoParamObj.Exposure > max)
        //        //    pVideoParamObj.Exposure = current;
        //        SliderExp.Value = pVideoParamObj.Exposure;
        //        LableExp.Text = Convert.ToString(SliderExp.Value);
        //        if (pVideoParamObj.isAutoExp == 0)
        //            CheckBoxExp.Checked = false;
        //        if (pVideoParamObj.isAutoExp == 1)
        //            CheckBoxExp.Checked = true;
        //    }

           
        //}

    }
}
