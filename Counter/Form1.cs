using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter
{
    public partial class WinCounter : Form
    {
        private double winCount = 0;
        private double loseCount = 0;
        private int winRate = 0;
        private double winStreakCount = 0;

        public WinCounter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void winInc1_Click(object sender, EventArgs e)
        {
            winCount += 1;
            winRate = WinRateCalculation();
            winStreakCount += 1;
            DataSetting();
        }

        private void winDec1_Click(object sender, EventArgs e)
        {
            if (winCount < 1)
            {
                winCount = 0;
            }
            else
            {
                winCount -= 1;
            }
            winRate = WinRateCalculation();
            DataSetting();
        }

        private void loseInc1_Click(object sender, EventArgs e)
        {
            loseCount += 1;
            winStreakCount = 0;
            winRate = WinRateCalculation();
            DataSetting();
        }
        private void loseDec1_Click(object sender, EventArgs e)
        {
            if (loseCount < 1)
            {
                loseCount = 0;
            }
            else
            {
                loseCount = loseCount - 1;
            }
            winRate = WinRateCalculation();
            DataSetting();
        }
        private int WinRateCalculation()
        {
            if(winCount == 0 && loseCount == 0) {
                return 0;
            }
            else
            {
                return (int)Math.Round((winCount / (winCount + loseCount) * 100), 0);
            }
           
        }

        private void DataSetting()
        {
            win.Text = winCount.ToString();
            lose.Text = loseCount.ToString();
            rate.Text = winRate.ToString() + "%";
            max.Text = winStreakCount.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        
        //---------------背景色-------------------------------------------
        private void TSMIBackground_Click(object sender, EventArgs e)
        {

        }
        //背景透過
        private void BackgroundTransmission_Click(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(1, 1, 1);
            this.BackColor = Color.FromArgb(1, 1, 1);
        }
        //背景色白
        private void BackgroundWhite_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        //背景色黒
        private void BackgroundBlack_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }
        //背景色赤
        private void BackgroundRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
        //背景色青
        private void BackgroundBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }
        //背景色緑
        private void BackgroundGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }
        //背景色カスタム
        private void BackgroundCustom_Click(object sender, EventArgs e)
        {

        }

        //---------------背景色-------------------------------------------
        //---------------文字色-------------------------------------------
        //文字色白
        private void FontColorWhite_Click(object sender, EventArgs e)
        {
            this.win.ForeColor = Color.White;
            this.winLabel.ForeColor = Color.White;
            this.lose.ForeColor = Color.White;
            this.loseLabel.ForeColor = Color.White;
            this.winStreakLabel.ForeColor = Color.White;
            this.max.ForeColor = Color.White;
            this.rateLabel.ForeColor = Color.White;
            this.rate.ForeColor = Color.White;
        }
        //文字色黒
        private void FontColorBlack_Click(object sender, EventArgs e)
        {
            this.win.ForeColor = Color.Black;
            this.winLabel.ForeColor = Color.Black;
            this.lose.ForeColor = Color.Black;
            this.loseLabel.ForeColor = Color.Black;
            this.winStreakLabel.ForeColor = Color.Black;
            this.max.ForeColor = Color.Black;
            this.rateLabel.ForeColor = Color.Black;
            this.rate.ForeColor = Color.Black;
        }
        //文字色赤
        private void FontColorRed_Click(object sender, EventArgs e)
        {
            this.win.ForeColor = Color.Red;
            this.winLabel.ForeColor = Color.Red;
            this.lose.ForeColor = Color.Red;
            this.loseLabel.ForeColor = Color.Red;
            this.winStreakLabel.ForeColor = Color.Red;
            this.max.ForeColor = Color.Red;
            this.rateLabel.ForeColor = Color.Red;
            this.rate.ForeColor = Color.Red;
        }
        //文字色青
        private void FontColorBlue_Click(object sender, EventArgs e)
        {
            this.win.ForeColor = Color.Blue;
            this.winLabel.ForeColor = Color.Blue;
            this.lose.ForeColor = Color.Blue;
            this.loseLabel.ForeColor = Color.Blue;
            this.winStreakLabel.ForeColor = Color.Blue;
            this.max.ForeColor = Color.Blue;
            this.rateLabel.ForeColor = Color.Blue;
            this.rate.ForeColor = Color.Blue;
        }
        //文字色緑
        private void FontColorGreen_Click(object sender, EventArgs e)
        {
            this.win.ForeColor = Color.Green;
            this.winLabel.ForeColor = Color.Green;
            this.lose.ForeColor = Color.Green;
            this.loseLabel.ForeColor = Color.Green;
            this.winStreakLabel.ForeColor = Color.Green;
            this.max.ForeColor = Color.Green;
            this.rateLabel.ForeColor = Color.Green;
            this.rate.ForeColor = Color.Green;
        }
        //文字色カスタム
        private void カスタマイズToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
        //---------------文字色-------------------------------------------
        //---------------ボックスカラー-----------------------------------
        //ボックスカラー透過
        private void BoxColorTransmission_Click(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.FromArgb(1, 1, 1);
            this.panel2.BackColor = Color.FromArgb(1, 1, 1);
            this.panel4.BackColor = Color.FromArgb(1, 1, 1);
            this.panel6.BackColor = Color.FromArgb(1, 1, 1);
            this.panel8.BackColor = Color.FromArgb(1, 1, 1);
        }
        //ボックスカラー白
        private void BoxColorWhite_Click(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.White;
            this.panel4.BackColor = Color.White;
            this.panel6.BackColor = Color.White;
            this.panel8.BackColor = Color.White;
        }
        //ボックスカラー黒
        private void BoxColorBlack_Click(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Black;
            this.panel4.BackColor = Color.Black;
            this.panel6.BackColor = Color.Black;
            this.panel8.BackColor = Color.Black;
        }
        //ボックスカラー赤
        private void BoxColorRed_Click(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Red;
            this.panel4.BackColor = Color.Red;
            this.panel6.BackColor = Color.Red;
            this.panel8.BackColor = Color.Red;
        }
        //ボックスカラー青
        private void BoxColorBlue_Click(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Blue;
            this.panel4.BackColor = Color.Blue;
            this.panel6.BackColor = Color.Blue;
            this.panel8.BackColor = Color.Blue;
        }
        //ボックスカラー緑
        private void BoxColorGreen_Click(object sender, EventArgs e)
        {
            this.panel2.BackColor = Color.Green;
            this.panel4.BackColor = Color.Green;
            this.panel6.BackColor = Color.Green;
            this.panel8.BackColor = Color.Green;
        }
        //ボックスカラーカスタム
        private void BoxColorCustom_Click(object sender, EventArgs e)
        {

        }
        //---------------ボックスカラー-----------------------------------
        //---------------ボックス枠色-------------------------------------
        //ボックス枠色透過
        private void BorderColorTransmission_Click(object sender, EventArgs e)
        {

        }
         //ボックス枠色白
         private void BorderColorWhite_Click(object sender, EventArgs e)
        {
 
        }
        //ボックス枠色黒
        private void BorderColorBlack_Click(object sender, EventArgs e)
        {

        }
        //ボックス枠色赤
        private void BorderColorRed_Click(object sender, EventArgs e)
        {

        }
        //ボックス枠色青
        private void BorderColorBlue_Click(object sender, EventArgs e)
        {

        }
        //ボックス枠色緑
        private void BorderColorGreen_Click(object sender, EventArgs e)
        {

        }
        //ボックス枠色カスタム
        private void BorderColorCustom_Click(object sender, EventArgs e)
        {

        }
        //---------------ボックス枠色-------------------------------------
        //---------------表示有効化---------------------------------------
        //WIN
        private void WinOn_Click(object sender, EventArgs e)
        {

        }

        private void WinOff_Click(object sender, EventArgs e)
        {

        }
        //LOSE
        private void LoseOn_Click(object sender, EventArgs e)
        {

        }
        
        private void LoseOff_Click(object sender, EventArgs e)
        {

        }
        //連勝数
        private void WinStreakOn_Click(object sender, EventArgs e)
        {

        }

        private void WinStreakOff_Click(object sender, EventArgs e)
        {

        }
        //勝率
        private void WinRateOn_Click(object sender, EventArgs e)
        {

        }

        private void WinRateOff_Click(object sender, EventArgs e)
        {

        }
        //---------------表示有効化---------------------------------------
    }
}
