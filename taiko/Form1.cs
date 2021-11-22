using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class Form1 : Form
    {
            Timer timer; //System.Windows.FormsにあるClass「Timer」

    List<float> x = new List<float>() { 406, 446, 496, 546, 586};  // 図形の x 座標
    List<float> y = new List<float>() { 89, 224, 479, 734, 869};  // 図形の y 座標

    int w = 927; //図形の幅
    int h = 120; //図形の高さ

    float ax = 4; //interval ごとに進む図形の座標間隔（低速）
    float ax0 = 5; //interval ごとに進む図形の座標間隔（高速）
    float ay = 13.5F; //interval ごとに進む図形の座標間隔（低速）
    float ay0 = 25.5F; //interval ごとに進む図形の座標間隔（高速）

        public Form1()
        {
            InitializeComponent();

            timer = new Timer()
            {
                Interval = 1,
                Enabled = false, //trueならタイマー自動開始、flaseは逆
            };



            // 「一定時間が経過する」というイベント後の処理（イベントハンドラ）を「timer_Tick」という名前で設定
            timer.Tick += new EventHandler(timer_Tick);　

            void timer_Tick(object sender, EventArgs e) //イベントハンド
            {
            this.Invalidate();  // 再描画を促す（図形の残像を残さない）
            };

            this.DoubleBuffered = true;  // ダブルバッファリング


        }

  
        protected override void OnPaint(PaintEventArgs e)
        {
            // 図形を定義
            RectangleF rect0 = new RectangleF(x[0], y[0], w, h); //above 1
            RectangleF rect1 = new RectangleF(x[1], y[1], w, h); //above 2
            RectangleF rect2 = new RectangleF(x[2], y[2], w, h); //center
            RectangleF rect3 = new RectangleF(x[3], y[3], w, h); //below 1
            RectangleF rect4 = new RectangleF(x[4], y[4], w, h); //below 2

            // 図形内のテキスト（曲名）を定義
            string text1 = "Music1";
            string text2 = "Music2";
            string text3 = "Music3";
            string text4 = "Music4";
            string text5 = "Music5";

            // 図形内のテキスト（曲名）のフォントを定義
            Font font1 = new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);

            // 図形を描画
            e.Graphics.DrawString(text1, font1, Brushes.Black, rect0);
            e.Graphics.DrawString(text2, font1, Brushes.Black, rect1);
            e.Graphics.DrawString(text3, font1, Brushes.Black, rect2);
            e.Graphics.DrawString(text4, font1, Brushes.Black, rect3);
            e.Graphics.DrawString(text5, font1, Brushes.Black, rect4);


            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect0));
            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect1));
            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect2));
            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect3));
            e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rect4));

            this.KeyDown += new KeyEventHandler(ScrollDown);

            // KeyDown イベントのイベントハンドラ
            void ScrollDown(object sender2, KeyEventArgs f)
            {
                // Shift+Esc キーが押されていたら
                if (f.KeyCode == Keys.Down)
                {
                    timer.Start();
                }
            }

            //図形を所定の位置まで移動
            int count = 1;
            if(y[count] > 479){
                timer.Stop();
            count = count - 1;
            }else{

            }
                

            // フレームアウトした図形を上へ移動
            int n;
            for(n = 0; n <=4; n++)
                if(y[n] < 224 ){
                    x[n] += ax;
                    y[n] += ay;
                }
                else if(y[n] < 734){
                    x[n] += ax0;
                    y[n] += ay0;
                }
                else if(y[n] >= 734){
                    x[n] += ax0;
                    y[n] += ay0;
                }
                else if (y[n] > ClientSize.Height){
                    y[n] = -122;
                    x[n] = 366;
                }
        }
    }
}
