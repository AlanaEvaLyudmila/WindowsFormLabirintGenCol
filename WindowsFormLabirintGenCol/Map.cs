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
        char[,] labirint;
        Point player;
        int rows, cols;
        Dictionary<string,int> data = new Dictionary<string,int>();
        Stack<Point> history = new Stack<Point>();
        Queue<string> logs = new Queue<string>();
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

        Dictionary<char, Image> images = new Dictionary<char, Image>();

        public Map()
        {
            InitializeComponent();
            data["Очки"] = 0;
            data["Ключи"] = 0;
        }
        void LoadMap()
        {
            images.Clear();
            foreach (var item in map)
            {
                images[item.Key] = Image.FromFile(item.Value);
            }
            string[] lines = File.ReadAllLines("resourses/map.txt");

            rows = lines.Length;
            cols = lines[0].Length;

            labirint = new char[rows, cols];

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
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    char c = lines[y][x];

                    if (c == 'P')
                    {
                        player = new Point(x,y);
                        labirint[y, x] = '.'; 
                    }
                    else
                        labirint[y, x] = c;
                }
            }
            DrawMap();

        }
        void DrawMap()
        {
            for (int y = 0; y < rows; y++)
            {
                for (int x = 0; x < cols; x++)
                {
                    char c = labirint[y, x];
                    dataGridViewLabirint[x, y].Value = images[c];
                }
            }
            dataGridViewLabirint[player.X, player.Y].Value = images['P'];

        }
        void MovePlayer(int dx,int dy)
        {
            Point next = new Point(player.X + dx, player.Y + dy);
            if (next.X < 0 || next.Y < 0 || next.X >= cols || next.Y >= rows)
                return;
            char nextCell = labirint[next.Y, next.X];
            if (nextCell == '#')
            {
                AddLog("Стена");
                return;
            }
            if (nextCell == 'D')
            {
                if (data["Ключи"] > 0)
                {
                    
                    labirint[next.Y, next.X] = 'C';
                    AddLog("Дверь открыта");
                }
                else
                {
                    AddLog("Нужен ключ");
                }
                
            }
            history.Push(player);
            dataGridViewLabirint[player.X,player.Y].Value = images[labirint[player.Y,player.X]];

            if (labirint[player.Y, player.X] == 'C')
            {
                data["Очки"] += 10;
                labirint[player.Y, player.X] = '.';
                AddLog("Алмаз");
                
            }

            if (labirint[player.Y, player.X] == 'K')
            {
                data["Ключи"] += 1;
                labirint[player.Y, player.X] = '.';
                AddLog("Ключ получен");
            }

            if (labirint[player.Y, player.X] == 'E')
            {
                if (data["Очки"] == 20)
                {
                    AddLog("Победа!");
                }
                else
                {
                    AddLog("Не хватает очков");
                }
            }

            player = next;
            dataGridViewLabirint[player.X, player.Y].Value = images['P'];
            UpdateInfo();
        }
        private void Map_Load(object sender, EventArgs e)
        {
            LoadMap();
        }

        void AddLog(string text)
        {
            logs.Enqueue(text);
            
            listBoxMessages.Items.Clear();
            foreach (string s in logs)
            {
                listBoxMessages.Items.Add(s);
            }
        }

        void UpdateInfo()
        {
            labelScore.Text = "Счёт: " + data["Очки"].ToString();
            labelKeys.Text = "Ключи: " + data["Ключи"].ToString();
        }
        private void Map_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) MovePlayer(0,-1);
            if (e.KeyCode == Keys.Down) MovePlayer(0, 1);
            if (e.KeyCode == Keys.Left) MovePlayer(-1, 0);
            if (e.KeyCode == Keys.Right) MovePlayer(1, 0);

        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            LoadMap();
            listBoxMessages.Items.Clear ();
        }

        private void dataGridViewLabirint_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
