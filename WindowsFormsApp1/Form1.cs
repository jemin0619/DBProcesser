using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataSet dataset = new DataSet();

        private void INPUT_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!openFileDialog.FileName.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("파일 확장자가 xlsx가 아닙니다.", "경고");
                        return;
                    }
                    INPUT_textbox.Text = openFileDialog.FileName;
                    comboBox1.Items.Clear();
                    dataGridView1.ClearSelection();
                }
            }
        }

        private void READ_button_Click(object sender, EventArgs e)
        {
            if (!INPUT_textbox.Text.EndsWith(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("파일 확장자가 xlsx가 아닙니다.", "경고");
                return;
            }
            readDB(INPUT_textbox.Text);
            updateCombobox();
        }

        // filePath의 xlsx 파일을 읽어서 DataSet에 모든 시트 저장
        private void readDB(string filePath)
        {
            // 엑셀 파일의 연결 문자열 (엑셀 버전에 맞는 프로바이더 사용)
            string connString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={filePath};Extended Properties='Excel 12.0 Xml;HDR=YES'";

            DataSet ds = new DataSet();

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();

                    // Excel 파일에 포함된 시트 이름 조회
                    DataTable dtSheet = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                    if (dtSheet.Rows.Count > 0)
                    {
                        // 각 시트의 데이터를 DataSet에 추가
                        foreach (DataRow row in dtSheet.Rows)
                        {
                            string sheetName = row["TABLE_NAME"].ToString();
                            string query = $"SELECT * FROM [{sheetName}]";
                            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
                            DataTable dt = new DataTable(sheetName);
                            adapter.Fill(dt);

                            // DataSet에 시트 추가
                            ds.Tables.Add(dt);
                        }

                        // DataGridView에 첫 번째 시트의 데이터를 표시
                        dataGridView1.DataSource = ds.Tables[0]; // 첫 번째 시트를 DataGridView에 표시

                        // 만약 모든 시트를 ComboBox 등으로 보여주고 싶다면
                        comboBox1.Items.Clear();
                        foreach (DataTable table in ds.Tables)
                        {
                            comboBox1.Items.Add(table.TableName);
                        }
                        dataset = ds;
                    }
                    else
                    {
                        MessageBox.Show("엑셀 파일에 시트가 없습니다.", "경고");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"엑셀 파일을 읽는 중 오류가 발생했습니다: {ex.Message}", "오류");
                }
            }
        }


        //dataset에 저장된 
        private void updateCombobox()
        {
            //comboBox1.Items.Clear();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataset.Tables[comboBox1.SelectedIndex];
        }
    }
}
