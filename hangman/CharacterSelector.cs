using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hangman
{
    public partial class CharacterSelector : UserControl
    {
        Bitmap[] headImages;
        Bitmap[] torsoImages;
        Bitmap[] leftArmImages;
        Bitmap[] rightArmImages;
        Bitmap[] leftLegImages;
        Bitmap[] rightLegImages;
        int currentHead, currentTorso, currentLeftArm, currentRightArm, currentLeftLeg, currentRightLeg;

        public CharacterSelector()
        {
            InitializeComponent();
            Bitmap head1Image = hangman.Properties.Resources.head1;
            Bitmap head2Image = hangman.Properties.Resources.head2;
            Bitmap head3Image = hangman.Properties.Resources.head3;
            Bitmap head4Image = hangman.Properties.Resources.trump;
            Bitmap head5Image = hangman.Properties.Resources.shrek;
            Bitmap head6Image = hangman.Properties.Resources.statuehead;
            //Bitmap head7Image = hangman.Properties.Resources.nygiraf;
            Bitmap head8Image = hangman.Properties.Resources.popeye;
            headImages = new Bitmap[7];
            headImages[0] = head1Image;
            headImages[1] = head2Image;
            headImages[2] = head3Image;
            headImages[3] = head4Image;
            headImages[4] = head5Image;
            headImages[5] = head6Image;
            //headImages[6] = head7Image;
            headImages[6] = head8Image;
            Bitmap torso1Image = hangman.Properties.Resources.torso1;
            Bitmap torso2Image = hangman.Properties.Resources.torso2;
            Bitmap torso3Image = hangman.Properties.Resources.torso3;
            Bitmap torso4Image = hangman.Properties.Resources.krop;
            torsoImages = new Bitmap[4];
            torsoImages[0] = torso1Image;
            torsoImages[1] = torso2Image;
            torsoImages[2] = torso3Image;
            torsoImages[3] = torso4Image;
            Bitmap leftArm1Image = hangman.Properties.Resources.leftarm1;
            Bitmap leftArm2Image = hangman.Properties.Resources.leftarm2;
            Bitmap leftArm3Image = hangman.Properties.Resources.leftarm3;
            leftArmImages = new Bitmap[3];
            leftArmImages[0] = leftArm1Image;
            leftArmImages[1] = leftArm2Image;
            leftArmImages[2] = leftArm3Image;
            Bitmap rightArm1Image = hangman.Properties.Resources.rightarm1;
            Bitmap rightArm2Image = hangman.Properties.Resources.rightarm2;
            Bitmap rightArm3Image = hangman.Properties.Resources.rightarm3;
            rightArmImages = new Bitmap[3];
            rightArmImages[0] = rightArm1Image;
            rightArmImages[1] = rightArm2Image;
            rightArmImages[2] = rightArm3Image;
            Bitmap leftLeg1Image = hangman.Properties.Resources.leftleg1;
            Bitmap leftLeg2Image = hangman.Properties.Resources.leftleg2;
            Bitmap leftLeg3Image = hangman.Properties.Resources.leftleg3;
            Bitmap leftLeg4Image = hangman.Properties.Resources.witchlegleft;
            Bitmap leftLeg5Image = hangman.Properties.Resources.chickenlegleft;
            leftLegImages = new Bitmap[5];
            leftLegImages[0] = leftLeg1Image;
            leftLegImages[1] = leftLeg2Image;
            leftLegImages[2] = leftLeg3Image;
            leftLegImages[3] = leftLeg4Image;
            leftLegImages[4] = leftLeg5Image;
            Bitmap rightLeg1Image = hangman.Properties.Resources.rightleg1;
            Bitmap rightLeg2Image = hangman.Properties.Resources.rightleg2;
            Bitmap rightLeg3Image = hangman.Properties.Resources.rightleg3;
            Bitmap rightLeg4Image = hangman.Properties.Resources.witchlegright;
            Bitmap rightLeg5Image = hangman.Properties.Resources.chickenlegright;
            rightLegImages = new Bitmap[5];
            rightLegImages[0] = rightLeg1Image;
            rightLegImages[1] = rightLeg2Image;
            rightLegImages[2] = rightLeg3Image;
            rightLegImages[3] = rightLeg4Image;
            rightLegImages[4] = rightLeg5Image;
            int[] bodyParts = Globals.bodyParts;
            currentHead = bodyParts[0];
            headImage.Image = headImages[bodyParts[0]];
            currentTorso = bodyParts[1];
            torsoImage.Image = torsoImages[bodyParts[1]];
            currentLeftArm = bodyParts[2];
            leftArmImage.Image = leftArmImages[bodyParts[2]];
            currentRightArm = bodyParts[3];
            rightArmImage.Image = rightArmImages[bodyParts[3]];
            currentLeftLeg = bodyParts[4];
            leftLegImage.Image = leftLegImages[bodyParts[4]];
            currentRightLeg = bodyParts[5];
            rightLegImage.Image = rightLegImages[bodyParts[5]];
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            int[] bodyparts = { currentHead, currentTorso, currentLeftArm, currentRightArm, currentLeftLeg, currentRightLeg };
            Globals.bodyParts = bodyparts;
            MainMenu mainmenu = new MainMenu();
            Parent.Controls.Add(mainmenu);
            Parent.Controls.Remove(this);
        }

        private void prevHeadButton_Click(object sender, EventArgs e)
        {
            currentHead--;
            if (currentHead == -1)
            {
                currentHead = headImages.Length - 1;
            }
            headImage.Image = headImages[currentHead];
        }

        private void nextHeadButton_Click(object sender, EventArgs e)
        {
            currentHead++;
            if (currentHead == headImages.Length)
            {
                currentHead = 0;
            }
            headImage.Image = headImages[currentHead];
        }

        private void prevTorsoButton_Click(object sender, EventArgs e)
        {
            currentTorso--;
            if (currentTorso == -1)
            {
                currentTorso = torsoImages.Length - 1;
            }
            torsoImage.Image = torsoImages[currentTorso];
        }

        private void nextTorsoButton_Click(object sender, EventArgs e)
        {
            currentTorso++;
            if (currentTorso == torsoImages.Length)
            {
                currentTorso = 0;
            }
            torsoImage.Image = torsoImages[currentTorso];
        }

        private void prevLeftArmButton_Click(object sender, EventArgs e)
        {
            currentLeftArm--;
            if (currentLeftArm == -1)
            {
                currentLeftArm = 2;
            }
            leftArmImage.Image = leftArmImages[currentLeftArm];
        }

        private void nextLeftArmButton_Click(object sender, EventArgs e)
        {
            currentLeftArm++;
            if (currentLeftArm == 3)
            {
                currentLeftArm = 0;
            }
            leftArmImage.Image = leftArmImages[currentLeftArm];
        }

        private void prevRightArmButton_Click(object sender, EventArgs e)
        {
            currentRightArm--;
            if (currentRightArm == -1)
            {
                currentRightArm = 2;
            }
            rightArmImage.Image = rightArmImages[currentRightArm];
        }

        private void nextHeadButton_Click_1(object sender, EventArgs e)
        {
            currentHead++;
            if (currentHead == headImages.Length)
            {
                currentHead = 0;
            }
            headImage.Image = headImages[currentHead];
        }

        private void nextRightArmButton_Click(object sender, EventArgs e)
        {
            currentRightArm++;
            if (currentRightArm == 3)
            {
                currentRightArm = 0;
            }
            rightArmImage.Image = rightArmImages[currentRightArm];
        }

        private void prevLeftLegButton_Click(object sender, EventArgs e)
        {
            currentLeftLeg--;
            if (currentLeftLeg == -1)
            {
                currentLeftLeg = leftLegImages.Length - 1;
            }
            leftLegImage.Image = leftLegImages[currentLeftLeg];
        }

        private void nextLeftLegButton_Click(object sender, EventArgs e)
        {
            currentLeftLeg++;
            if (currentLeftLeg == leftLegImages.Length)
            {
                currentLeftLeg = 0;
            }
            leftLegImage.Image = leftLegImages[currentLeftLeg];
        }

        private void prevRightLegButton_Click(object sender, EventArgs e)
        {
            currentRightLeg--;
            if (currentRightLeg == -1)
            {
                currentRightLeg = rightLegImages.Length - 1;
            }
            rightLegImage.Image = rightLegImages[currentRightLeg];
            Console.WriteLine(currentRightLeg);
        }

        private void nextRightLegButton_Click(object sender, EventArgs e)
        {
            currentRightLeg++;
            if (currentRightLeg == rightLegImages.Length)
            {
                currentRightLeg = 0;
            }
            rightLegImage.Image = rightLegImages[currentRightLeg];
            Console.WriteLine(currentRightLeg);
            
        }
    }
}
