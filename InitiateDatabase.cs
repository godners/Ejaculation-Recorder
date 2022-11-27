using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.Serialization;

namespace ER
{
    internal static class InitiateDatabase
    {
        #pragma warning disable CS8618 
        private static DataSet DataSetER;
        #pragma warning restore CS8618 

        internal static void Initiate(String Username, String Password)
        {
            DataSetER = new() { DataSetName = $"DS_{Username}", CaseSensitive = false };
            InitiateTable(); InitiateClass(); InitiateDescription();
            //写入XML(); 加密XML();
        }
        private static void InitiateTable()
        {
            DataTable DT_Class = new("DT_Class");
            DataColumn DC_Class_ID = new()
            {
                ColumnName = "DC_Class_ID",
                AllowDBNull = false,
                Unique = true,
                Caption = "DC_Class_ID",
                DataType = typeof(Int32)
            };
            DT_Class.Columns.Add(DC_Class_ID);
            DataColumn DC_Class_Description = new()
            {
                ColumnName = "DC_Class_Description",
                AllowDBNull = false,
                MaxLength = 32,
                Caption = "DC_Class_Description",
                DataType = typeof(String),
            };
            DT_Class.Columns.Add(DC_Class_Description);
            String Expression_Class_Display = "CONVERT(DC_Class_ID, System.String) + ' - ' + DC_Class_Description";
            DataColumn DC_Class_Display = new()
            {
                ColumnName = "DC_Class_Display",
                Caption = "DC_Class_Display",
                DataType = typeof(String),
                Expression = Expression_Class_Display,
                ColumnMapping = MappingType.Attribute,
                ReadOnly = true
            };
            DT_Class.Columns.Add(DC_Class_Display);
            DataSetER.Tables.Add(DT_Class);
            DataTable DT_Dictionary = new("DT_Dictionary");
            DataColumn DC_Dictionary_ID = new()
            {
                ColumnName = "DC_Dictionary_ID",
                AllowDBNull = false,
                Unique = true,
                Caption = "DC_Dictionary_ID",
                DataType = typeof(Int32)
            };
            DT_Dictionary.Columns.Add(DC_Dictionary_ID);
            DataColumn DC_Dictionary_Short = new()
            {
                ColumnName = "DC_Dictionary_Short",
                AllowDBNull = false,
                MaxLength = 8,
                Caption = "DC_Dictionary_Short",
                DataType = typeof(String),
            };
            DT_Dictionary.Columns.Add(DC_Dictionary_Short);
            DataColumn DC_Dictionary_Description = new()
            {
                ColumnName = "DC_Dictionary_Description",
                AllowDBNull = false,
                MaxLength = 64,
                Caption = "DC_Dictionary_Description",
                DataType = typeof(String)
            };
            DT_Dictionary.Columns.Add(DC_Dictionary_Description);
            DataColumn DC_Dictionary_Class = new()
            {
                ColumnName = "DC_Dictionary_Class",
                AllowDBNull = false,
                Caption = "DC_Dictionary_Class",
                DataType = typeof(Int32)
            };
            DT_Dictionary.Columns.Add(DC_Dictionary_Class);
            String Expression_Dictionary_Display = "CONVERT(DC_Dictionary_ID, System.String) + ' - ' + DC_Dictionary_Description";
            DataColumn DC_Dictionary_Display = new()
            {
                ColumnName = "DC_Dictionary_Display",
                Caption = "DC_Dictionary_Display",
                DataType = typeof(String),
                Expression = Expression_Dictionary_Display,
                ColumnMapping = MappingType.Attribute,
                ReadOnly = true
            };
            DT_Dictionary.Columns.Add(DC_Dictionary_Display);
            DataSetER.Tables.Add(DT_Dictionary);
        }
        // 未完成：设计DT_Record数据模型，创建表
        private static void InitiateClass()
        {
            InsertClassRow(1, "Location");    //地点
            InsertClassRow(2, "Anesthetic");  //麻醉剂
            InsertClassRow(3, "Aphrodisiac"); //壮阳剂
            InsertClassRow(4, "Surgical");    //手术
            InsertClassRow(5, "Bundle");      //捆绑
            InsertClassRow(6, "Lubricant");   //润滑油
            InsertClassRow(7, "Posture");     //姿势
            InsertClassRow(8, "Evoked");      //诱发
            InsertClassRow(9, "Position");    //部位
        }
        private static void InsertClassRow(Int32 DC_Class_ID,String DC_Class_Description)
        {
            #pragma warning disable CS8602
            DataRow DR_Class = DataSetER.Tables["DT_Class"].NewRow();
            DR_Class["DC_Class_ID"] = DC_Class_ID;
            DR_Class["DC_Class_Description"] = DC_Class_Description;
            DataSetER.Tables["DT_Class"].Rows.Add(DR_Class);
            #pragma warning restore CS8602
        }
        private static void InitiateDescription()
        {
            InsertDescriptionRow(1, "Prc.", "Procaine", 2);             //普鲁卡因
            InsertDescriptionRow(2, "Ldc.", "Lidocaine", 2);            //利多卡因
            InsertDescriptionRow(3, "Ttc.", "Tetracaine", 2);           //丁卡因
            InsertDescriptionRow(4, "Dnl.", "Adrenaline", 2);           //肾上腺素
            InsertDescriptionRow(5, "Sdnf.", "Sildenafil", 3);          //西地那非
            InsertDescriptionRow(6, "Vdnf.", "Vardenafil", 3);          //伐地那非
            InsertDescriptionRow(7, "Tdlf.", "Tadalafil", 3);           //他打拉菲
            InsertDescriptionRow(8, "Dbxt.", "Daboxetine", 3);          //达伯西汀
            InsertDescriptionRow(9, "Macho", "Macho", 3);               //南美玛咖
            InsertDescriptionRow(10, "Ppl.", "Papilla", 9);             //乳头
            InsertDescriptionRow(11, "Gl.B.", "Glans Body", 9);         //龟头主体
            InsertDescriptionRow(12, "Gl.E.", "Glans Edge", 9);         //龟头边缘
            InsertDescriptionRow(13, "Utr.Of.", "Urethral Orifice", 9); //马眼
            InsertDescriptionRow(14, "Crn.Sl.", "Coronary Sulcus", 9);  //冠状沟
            InsertDescriptionRow(15, "Sp.Pn.", "Scapus Penis", 9);      //阴茎体
            InsertDescriptionRow(16, "Rd.Pn.", "Radices Penis", 9);     //阴茎根
            InsertDescriptionRow(17, "Fnl.", "Frenulum", 9);            //阴茎系带
            InsertDescriptionRow(18, "Utr.", "Urethral", 9);            //尿道
            InsertDescriptionRow(19, "Pst.", "Prostate", 9);            //前列腺
            InsertDescriptionRow(20, "Urc.", "Urocyst", 9);             //膀胱
            InsertDescriptionRow(21, "Srt.", "Scrotum", 9);             //阴囊
            InsertDescriptionRow(22, "Srt.St.", "Scrotum Septum", 9);   //阴囊中隔
            InsertDescriptionRow(23, "Tst.", "Testis", 9);              //睾丸
        }
        // 未完成：4-手术，5-捆绑，6-润滑油，7-姿势，8-诱发
        private static void InsertDescriptionRow
            (Int32 DC_Dictionary_ID, String DC_Dictionary_Short, 
            String DC_Dictionary_Description, Int32 DC_Dictionary_Class)
        {
            #pragma warning disable CS8602
            DataRow DR_Description = DataSetER.Tables["DT_Dictionary"].NewRow();
            DR_Description["DC_Dictionary_ID"] = DC_Dictionary_ID;
            DR_Description["DC_Dictionary_Short"] = DC_Dictionary_Short;
            DR_Description["DC_Dictionary_Description"] = DC_Dictionary_Description;
            DR_Description["DC_Dictionary_Class"] = DC_Dictionary_Class;
            DataSetER.Tables["DT_Dictionary"].Rows.Add(DR_Description);
            #pragma warning restore CS8602
        }
        


        
        

    }
}
