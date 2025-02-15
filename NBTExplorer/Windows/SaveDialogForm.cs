using Substrate.Nbt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace NBTExplorer.Windows
{
    public partial class SaveDialogForm : Form
    {
        public EndiannessType _endian;
        public HeaderType _header;
        public bool _wasAccepted = false;

        private bool _endianSelected = false;
        private bool _headerSelected = false;

        public SaveDialogForm()
        {
            InitializeComponent();
        }

        private void CheckSaveRequirements()
        {
            SaveButton.Enabled = _endian == EndiannessType.BigEndian || _headerSelected && _endianSelected;
        }

        private void SaveDialogForm_Load(object sender, EventArgs e)
        {

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            Close();
            _wasAccepted = true;
        }

        private void LittleEndianButton_CheckedChanged(object sender, EventArgs e)
        {
            _endian = EndiannessType.LittleEndian;
            _endianSelected = true;
            CheckSaveRequirements();
            EntityButton.Enabled = LevelButton.Enabled = NoneButton.Enabled = true;
        }

        private void BigEndianButton_CheckedChanged(object sender, EventArgs e)
        {
            _endian = EndiannessType.BigEndian;
            _endianSelected = true;
            CheckSaveRequirements();
            EntityButton.Enabled = LevelButton.Enabled = NoneButton.Enabled = false;
        }
        private void LevelButton_CheckedChanged(object sender, EventArgs e)
        {
            _header = HeaderType.LevelHeader;
            _headerSelected = true;
            CheckSaveRequirements();
        }

        private void EntityButton_CheckedChanged(object sender, EventArgs e)
        {
            _header = HeaderType.EntityHeader;
            _headerSelected = true;
            CheckSaveRequirements();
        }
        
        private void NoneButton_CheckedChanged(object sender, EventArgs e)
        {
            _header = HeaderType.None;
            _headerSelected = true;
            CheckSaveRequirements();
        }

    }
}
