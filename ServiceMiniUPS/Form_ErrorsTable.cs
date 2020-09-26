using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceMiniUPS
{
    public partial class Form_ErrorsTable : Form
    {
        const int CountOfErrors = 10;
        const int CountOfTableColumns = 2;
        string[,] ErrorsDescriptionArr = new string[CountOfErrors, CountOfTableColumns] {{ "1",  "Пояснение ошибки 1"  }, 
                                                            { "2",  "Пояснение ошибки 2"  },
                                                            { "3",  "Пояснение ошибки 3"  },
                                                            { "4",  "Пояснение ошибки 4"  }, 
                                                            { "5",  "Пояснение ошибки 5"  }, 
                                                            { "6",  "Пояснение ошибки 6"  }, 
                                                            { "7",  "Пояснение ошибки 7"  },
                                                            { "8",  "Пояснение ошибки 8"  }, 
                                                            { "9",  "Пояснение ошибки 9"  },
                                                            { "10", "Пояснение ошибки 10" },
        };
        public Form_ErrorsTable()
        {
            InitializeComponent();
            
            for (int i = 0; i < CountOfErrors-1;  i++) dataGrid_ErrorTable.Rows.Add();
            for (int i = 0; i < CountOfErrors; i++)
            {    
                for (int j = 0; j < CountOfTableColumns; j++)
                {                    
                    dataGrid_ErrorTable.Rows[i].Cells[j].Value = ErrorsDescriptionArr[i, j];
                }               
            }
            dataGrid_ErrorTable.Rows[4].Cells[0].Style.ForeColor = Color.Red;
            dataGrid_ErrorTable.Rows[4].Cells[1].Style.ForeColor = Color.Red;
        }



        private void Form_ErrorsTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
