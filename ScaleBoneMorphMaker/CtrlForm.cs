using PEPlugin;
using PEPlugin.Pmx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScaleBoneMorphMaker
{
    public partial class CtrlForm : Form
    {
        IPERunArgs args;
        IPXPmx pmx;

        public CtrlForm(IPERunArgs input)
        {
            InitializeComponent();
            args = input;
            Format();
        }

        public void Format()
        {
            pmx = args.Host.Connector.Pmx.GetCurrentState();
        }

        private void CtrlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Visible = false;
            }
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            pmx = args.Host.Connector.Pmx.GetCurrentState();
            var selectedBones = args.Host.Connector.View.PmxView.GetSelectedBoneIndices().Select(i => pmx.Bone[i]).ToList();
            if (selectedBones.Count < 1)
            {
                MessageBox.Show("PmxViewで対象ボーンを選択してください");
                return;
            }

            // ボーンモーフを生成
            var ScaleMorph = PEStaticBuilder.Pmx.Morph();
            ScaleMorph.Name = "拡縮-" + selectedBones[0].Name;
            ScaleMorph.Kind = MorphKind.Bone;
            ScaleMorph.Panel = 4;

            // ボーンオフセットを生成
            foreach (var bone in selectedBones)
            {
                var offset = PEStaticBuilder.Pmx.BoneMorphOffset();
                offset.Bone = bone;
                offset.Translation = new PEPlugin.SDX.V3(
                    bone.Position.X * (float)numericX.Value - bone.Position.X,
                    bone.Position.Y * (float)numericY.Value - bone.Position.Y,
                    bone.Position.Z * (float)numericZ.Value - bone.Position.Z
                );
                ScaleMorph.Offsets.Add(offset);
            }

            pmx.Morph.Add(ScaleMorph);
            Utility.Update(args.Host.Connector, pmx, PmxUpdateObject.Morph);
            MessageBox.Show("完了");
        }
    }
}