using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormLabirintGenCol.Properties;
using System.IO;

namespace WindowsFormLabirintGenCol
{
    public partial class Map : Form
    {
        Dictionary<char, string> map = new Dictionary<char, string>()
        {
            {'#',"resourses/stone.jfif"},
            {'.',"resourses/grass.jfif" },
            {'P',"resourses/steve.png" },
            {'C',"resourses/diamond.jfif" },
            {'K',"resourses/key.png" },
            {'D',"resourses/door.jpg" },
            {'E',"resourses/exit.png" },
        };


        public Map()
        {
            InitializeComponent();
        }
        void LoadMap()
        {
            string[] lines = File.ReadAllLines("resourses/map.txt");

            int rows = lines.Length;
            int cols = lines[0].Length;

            dataGridViewLabirint.Rows.Clear();
            dataGridViewLabirint.Columns.Clear();

            for (int i = 0; i < cols; i++)
            {
                DataGridViewImageColumn col = new DataGridViewImageColumn();
                col.Width = 40;
                col.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGridViewLabirint.Columns.Add(col);

            }

            dataGridViewLabirint.RowCount = rows;

            for (int i = 0;i < rows;i++)
            {
                dataGridViewLabirint.Rows[i].Height = 40;
            }

            dataGridViewLabirint.Width = cols * 40 + 3;
            dataGridViewLabirint.Height = rows * 40 + 3;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    char c = lines[i][j];
                    string path = map[c];
                    if( path != null)
                    {
                        dataGridViewLabirint[j,i].Value = Image.FromFile(path);
                    }
                }
            }

        }
        private void Map_Load(object sender, EventArgs e)
        {
            LoadMap();
        }

        private void dataGridViewLabirint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
