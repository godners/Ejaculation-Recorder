using System.Data;
using System.Security.Cryptography;
using System.Text;
using static ER.Program;

namespace ER
{
    internal static class InitiateDatabase
    {
        internal static void Initiate(String DataFile, String Password)
        {
            DataSetER = new() { DataSetName = $"DS_{DataFile}", CaseSensitive = false };
            InitiateTable(); InitiateClass(); InitiateDescription();
            DataSetER.WriteXml("a.xml", XmlWriteMode.WriteSchema);
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
                Caption = "序号",
                DataType = typeof(Int32)
            };
            DataColumn DC_Class_Description = new()
            {
                ColumnName = "DC_Class_Description",
                AllowDBNull = false,
                MaxLength = 32,
                Caption = "描述",
                DataType = typeof(String),
            };
            String Expression_Class_Display =
                "CONVERT(DC_Class_ID, System.String) + ' - ' + DC_Class_Description";
            DataColumn DC_Class_Display = new()
            {
                ColumnName = "DC_Class_Display",
                Caption = "类型",
                DataType = typeof(String),
                Expression = Expression_Class_Display,
                ColumnMapping = MappingType.Attribute,
                ReadOnly = true
            };
            DT_Class.Columns.Add(DC_Class_ID);
            DT_Class.Columns.Add(DC_Class_Description);
            DT_Class.Columns.Add(DC_Class_Display);
            DataSetER.Tables.Add(DT_Class);

            DataTable DT_Dictionary = new("DT_Dictionary");
            DataColumn DC_Dictionary_ID = new()
            {
                ColumnName = "DC_Dictionary_ID",
                AllowDBNull = false,
                Unique = true,
                Caption = "序号",
                DataType = typeof(Int32)
            };
            DataColumn DC_Dictionary_Class = new()
            {
                ColumnName = "DC_Dictionary_Class",
                AllowDBNull = false,
                Caption = "类型",
                DataType = typeof(Int32)
            };
            DataColumn DC_Dictionary_Short = new()
            {
                ColumnName = "DC_Dictionary_Short",
                AllowDBNull = false,
                MaxLength = 8,
                Caption = "缩写",
                DataType = typeof(String),
            };
            DataColumn DC_Dictionary_Description = new()
            {
                ColumnName = "DC_Dictionary_Description",
                AllowDBNull = false,
                MaxLength = 64,
                Caption = "描述",
                DataType = typeof(String)
            };
            String Expression_Dictionary_Display =
                "CONVERT(DC_Dictionary_ID, System.String) + ' - ' + DC_Dictionary_Description";
            DataColumn DC_Dictionary_Display = new()
            {
                ColumnName = "DC_Dictionary_Display",
                Caption = "字典",
                DataType = typeof(String),
                Expression = Expression_Dictionary_Display,
                ColumnMapping = MappingType.Attribute,
                ReadOnly = true
            };
            DT_Dictionary.Columns.Add(DC_Dictionary_ID);
            DT_Dictionary.Columns.Add(DC_Dictionary_Class);
            DT_Dictionary.Columns.Add(DC_Dictionary_Short);
            DT_Dictionary.Columns.Add(DC_Dictionary_Description);
            DT_Dictionary.Columns.Add(DC_Dictionary_Display);
            DataSetER.Tables.Add(DT_Dictionary);

            DataTable DT_Record = new DataTable("DT_Records");
            DataColumn DC_Record_ID = new()
            {
                ColumnName = "DC_Records_ID",
                AllowDBNull = false,
                Unique = true,
                Caption = "序号",
                DataType = typeof(Int32)
            };
            DataColumn DC_Record_Date = new()
            {
                ColumnName = "DC_Record_Date",
                AllowDBNull = false,
                Unique = false,
                Caption = "日期",
                DataType = typeof(DateTime)
            };
            DataColumn DC_Record_Location = new()
            {
                ColumnName = "DC_Record_Location",
                AllowDBNull = false,
                Unique = false,
                Caption = "地点",
                DataType = typeof(Int32),
                DefaultValue = @"{""Location"":{""ID"":199}}"
            };
            DataColumn DC_Record_Anesthetic = new()
            {
                ColumnName = "DC_Record_Anesthetic",
                AllowDBNull = false,
                Unique = false,
                Caption = "麻醉",
                DataType = typeof(String),
                DefaultValue = @"{""Anesthetic"":[{""ID"":200,""Position"":900}]}"
            };
            DataColumn DC_Record_Aphrodisiac = new()
            {
                ColumnName = "DC_Record_Aphrodisiac",
                AllowDBNull = false,
                Unique = false,
                Caption = "壮阳",
                DataType = typeof(String),
                DefaultValue = @"{""Aphrodisiac"":[{""ID"":300}]}"
            };
            DataColumn DC_Record_Surgical = new()
            {
                ColumnName = "DC_Record_Surgical",
                AllowDBNull = false,
                Unique = false,
                Caption = "手术",
                DataType = typeof(String),
                DefaultValue = @"{""Surgical"":[{""ID"":400,""Position"":900}]}"
            };
            DataColumn DC_Record_Bundle = new()
            {
                ColumnName = "DC_Record_Bundle",
                AllowDBNull = false,
                Unique = false,
                Caption = "捆绑",
                DataType = typeof(String),
                DefaultValue = @"{""Bundle"":[{""ID"":500,""Position"":900}]}"
            };
            DataColumn DC_Record_Lubricant = new()
            {
                ColumnName = "DC_Record_Lubricant",
                AllowDBNull = false,
                Unique = false,
                Caption = "润滑",
                DataType = typeof(String),
                DefaultValue = @"{""Lubricant"":{""ID"":600}}"
            };
            DataColumn DC_Record_Process = new()
            {
                ColumnName = "DC_Record_Posture",
                AllowDBNull = false,
                Unique = false,
                Caption = "过程",
                DataType = typeof(String),
                DefaultValue = @"{""Process"":[{""Posture"":799,""Action"":899,""Position"":999,""Note"":1000}]}"
            };
            DataColumn DC_Record_Evoked = new()
            {
                ColumnName = "DC_Record_Posture",
                AllowDBNull = false,
                Unique = false,
                Caption = "诱发",
                DataType = typeof(String),
                DefaultValue = @"{""Evoked"":{""Posture"":799,""Action"":899,""Position"":999,""Note"":1000}}"
            };
            DT_Record.Columns.Add(DC_Record_ID);
            DT_Record.Columns.Add(DC_Record_Date);
            DT_Record.Columns.Add(DC_Record_Location);
            DT_Record.Columns.Add(DC_Record_Anesthetic);
            DT_Record.Columns.Add(DC_Record_Aphrodisiac);
            DT_Record.Columns.Add(DC_Record_Surgical);
            DT_Record.Columns.Add(DC_Record_Bundle);
            DT_Record.Columns.Add(DC_Record_Lubricant);
            DT_Record.Columns.Add(DC_Record_Process);
            DT_Record.Columns.Add(DC_Record_Evoked);
            DataSetER.Tables.Add(DT_Record);

            //InsertClassRow(1, "Location");    //地点
            //InsertClassRow(2, "Anesthetic");  //麻醉
            //InsertClassRow(3, "Aphrodisiac"); //壮阳
            //InsertClassRow(4, "Surgical");    //手术
            //InsertClassRow(5, "Bundle");      //捆绑
            //InsertClassRow(6, "Lubricant");   //润滑
            //InsertClassRow(7, "Posture");     //姿势
            //InsertClassRow(8, "Action");      //动作
            //InsertClassRow(9, "Position");    //部位
            //InsertClassRow(10, "Note");       //附注
        }
        private static void InitiateClass()
        {
            InsertClassRow(0, "无");
            InsertClassRow(1, "地点");
            InsertClassRow(2, "麻醉");
            InsertClassRow(3, "壮阳");
            InsertClassRow(4, "手术");
            InsertClassRow(5, "捆绑");
            InsertClassRow(6, "润滑");
            InsertClassRow(7, "姿势");
            InsertClassRow(8, "动作");
            InsertClassRow(9, "部位");
            InsertClassRow(10, "附注");
        }
        private static void InsertClassRow(Int32 DC_Class_ID, String DC_Class_Description)
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
            InsertDescriptionRow(0, "无");
            InsertDescriptionRow(99, "其它");

            InsertDescriptionRow(100, "无");
            InsertDescriptionRow(199, "其它");

            InsertDescriptionRow(200, "无");
            InsertDescriptionRow(201, "普鲁卡因");
            InsertDescriptionRow(202, "利多卡因");
            InsertDescriptionRow(203, "丁卡因　");
            InsertDescriptionRow(204, "肾上腺素");
            InsertDescriptionRow(299, "其它");

            InsertDescriptionRow(300, "无");
            InsertDescriptionRow(301, "西地那非");
            InsertDescriptionRow(302, "伐地那非");
            InsertDescriptionRow(303, "他达那非");
            InsertDescriptionRow(304, "达伯西汀");
            InsertDescriptionRow(305, "南美玛咖");
            InsertDescriptionRow(399, "其它");

            InsertDescriptionRow(400, "无");
            InsertDescriptionRow(401, "系带挖洞");
            InsertDescriptionRow(499, "其它");

            InsertDescriptionRow(500, "无");
            InsertDescriptionRow(501, "乳胶皮筋");
            InsertDescriptionRow(502, "乳胶皮带");
            InsertDescriptionRow(503, "黑色套圈");
            InsertDescriptionRow(504, "止血胶管");
            InsertDescriptionRow(599, "其它");

            InsertDescriptionRow(600, "无");
            InsertDescriptionRow(601, "沐浴乳液");
            InsertDescriptionRow(602, "洗发露液");
            InsertDescriptionRow(603, "独爱极润");
            InsertDescriptionRow(699, "其它");

            InsertDescriptionRow(700, "无");
            InsertDescriptionRow(701, "双脚站立");
            InsertDescriptionRow(702, "双脚跨立");
            InsertDescriptionRow(703, "正坐椅凳");
            InsertDescriptionRow(704, "靠坐椅凳");
            InsertDescriptionRow(705, "正坐地面");
            InsertDescriptionRow(706, "靠坐地面");
            InsertDescriptionRow(707, "倒Ｙ跪地");
            InsertDescriptionRow(708, "Ｚ型跪地");
            InsertDescriptionRow(709, "胸靠躺地");
            InsertDescriptionRow(710, "仰头躺地");
            InsertDescriptionRow(799, "其它");

            InsertDescriptionRow(800, "无");
            InsertDescriptionRow(801, "前后套弄");
            InsertDescriptionRow(802, "卡阴茎跟");
            InsertDescriptionRow(803, "龟头则");
            InsertDescriptionRow(804, "前后顶裆");
            InsertDescriptionRow(805, "臀部收紧");
            InsertDescriptionRow(806, "绷劲顶裆");
            InsertDescriptionRow(807, "拨弄乳头");
            InsertDescriptionRow(808, "拉伸阴囊");
            InsertDescriptionRow(899, "其它");

            InsertDescriptionRow(900, "无");
            InsertDescriptionRow(901, "乳头");
            InsertDescriptionRow(902, "龟头体");
            InsertDescriptionRow(903, "龟头边缘");
            InsertDescriptionRow(904, "马眼");
            InsertDescriptionRow(905, "冠状沟");
            InsertDescriptionRow(906, "阴茎体");
            InsertDescriptionRow(907, "阴茎根");
            InsertDescriptionRow(908, "阴茎系带");
            InsertDescriptionRow(909, "尿道");
            InsertDescriptionRow(910, "前列腺");
            InsertDescriptionRow(911, "膀胱");
            InsertDescriptionRow(912, "阴囊");
            InsertDescriptionRow(913, "阴囊中隔");
            InsertDescriptionRow(914, "睾丸");
            InsertDescriptionRow(915, "输精管");
            InsertDescriptionRow(916, "肚脐");
            InsertDescriptionRow(999, "其它");

            InsertDescriptionRow(1000, "无");
            InsertDescriptionRow(1001, "左正手");
            InsertDescriptionRow(1002, "左反手");
            InsertDescriptionRow(1003, "右正手");
            InsertDescriptionRow(1004, "右反手");
            InsertDescriptionRow(1005, "双正手");
            InsertDescriptionRow(1006, "双反手");
            InsertDescriptionRow(1007, "左正正反");
            InsertDescriptionRow(1008, "左反右正");
            InsertDescriptionRow(1009, "掌心");
            InsertDescriptionRow(1010, "指根");
            InsertDescriptionRow(1099, "其它");
        }
        private static void InsertDescriptionRow(
            Int32 DC_Dictionary_ID, String DC_Dictionary_Short_Description)
        {
#pragma warning disable CS8602
            DataRow DR_Description = DataSetER.Tables["DT_Dictionary"].NewRow();
            DR_Description["DC_Dictionary_ID"] = DC_Dictionary_ID;
            DR_Description["DC_Dictionary_Short"] = DC_Dictionary_Short_Description;
            DR_Description["DC_Dictionary_Description"] = DC_Dictionary_Short_Description;
            DR_Description["DC_Dictionary_Class"] = (Int32)Math.Floor((Double)DC_Dictionary_ID / 100);
            DataSetER.Tables["DT_Dictionary"].Rows.Add(DR_Description);
#pragma warning restore CS8602
        }
        internal static void SaveDataFile(String DataFile, String Password)
        {
            DataSetER.WriteXml($"{DataFile}.temp", XmlWriteMode.WriteSchema);
            String ClearXML = File.ReadAllText($"{DataFile}.temp");

            Byte[] ByteXML = Encoding.UTF8.GetBytes(ClearXML);
            Byte[] ByteKey = Encoding.UTF8.GetBytes(HASH(Password));
            for (Int32 i = 0; i < ByteXML.Length; i++)
                ByteXML[i] ^= ByteKey[i % ByteKey.Length];
            File.WriteAllText(DataFile, Convert.ToBase64String(ByteXML));
        }
        internal static void LoadDataFile(String DataFile, String Password)
        {
            String Base64XML = File.ReadAllText(DataFile);
            Byte[] CipherXML = Convert.FromBase64String(Base64XML);
            Byte[] ByteKey = Encoding.UTF8.GetBytes(HASH(Password));
            for (Int32 i = 0; i < CipherXML.Length; i++)
                CipherXML[i] ^= ByteKey[i % ByteKey.Length];
            String ClearXML = Encoding.UTF8.GetString(CipherXML, 0, CipherXML.Length);
            File.WriteAllText($"{DataFile}.temp", ClearXML);
            DataSetER.ReadXml($"{DataFile}.temp", XmlReadMode.ReadSchema);
        }
        private static String HASH(String ClearText)
        {
            Byte[] Buffer = Encoding.UTF8.GetBytes(ClearText);
            Byte[] Data = SHA256.HashData(Buffer);
            StringBuilder Value = new();
            foreach (Byte Word in Data)
                Value.Append(Word.ToString("X2"));
            return Value.ToString();
        }
    }
}
