﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSV
{
    /// <summary>
    /// Lưu
    /// </summary>
    static class Luu
    {
        private static readonly string STT_COLUMN = "STT";
        static bool kt = true;
        public static bool KT
        {
            get{ return kt; }
            set { kt = value; }
        }

        public static DataTable CreateDataTable<T>(this IList<T> data)
        {
            PropertyDescriptorCollection props =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                PropertyDescriptor prop = props[i];
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(
            prop.PropertyType) ?? prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }

            table.Columns.Add(STT_COLUMN);
            for (int i=0; i<table.Rows.Count; i++)
            {
                table.Rows[i][STT_COLUMN] = (i + 1).ToString();
            }
            return table;
        }
    } 
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
