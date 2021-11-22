using System;
using System.Threading;
using System.Threading.Tasks;

namespace Project2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                // None : 自動調整しない
                // Font : フォントに大きさに伴って自動調整
                // Dpi : 画面のDPIにあわせて自動調整
                // Inherit : コンテナコントロールの設定に従って自動調整
            this.ClientSize = new System.Drawing.Size(1920, 1080);  // ウィンドウサイズ
            this.Text = "taiko";    // ウィンドウ名
            this.BackColor = System.Drawing.Color.Green;  // 背景色を設定
            this.Location = new System.Drawing.Point (0, 0);   //ウィンドウの位置

            System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(@"C:\Users\颯太\Desktop\Project2\TestPicture.png");
            this.BackgroundImage = bitmap;                  // 背景画像
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;  // 配置
            // None = 0,     左上に配置
            //  Tile = 1,    // タイル状に整列
            //  Center = 2,  // 中央に配置
            //  Stretch = 3, // 縦横比を維持せず拡縮
            //  Zoom = 4,    // 縦横比を維持して拡縮
        }
        #endregion
    }
}

