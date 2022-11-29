using Windows.UI.Input.Spatial;
using static ER.RecordElement;
namespace ER
{
    internal class Record
    {
        private Int32 _ID; private DateTime _Date; private Location _Location; 
        private Anesthetic _Anesthetic; private Aphrodisiac _Aphrodisiac; 
        private Surgical _Surgical; private Bundle _Bundle; private Lubricant _Lubricant;
        private Process _Process; private Evoked _Evoked;

        #pragma warning disable CS8618
        internal Record() { }
        #pragma warning restore CS8618
        internal Record(Int32 ID, DateTime Date, Location Location , 
            Anesthetic Anesthetic, Aphrodisiac Aphrodisiac, Surgical Surgical, 
            Bundle Bundle, Lubricant Lubricant, Process Process, Evoked Evoked)
        {
            _ID = ID; _Date = Date; _Location = Location; _Anesthetic = Anesthetic; 
            _Aphrodisiac = Aphrodisiac;_Surgical = Surgical; _Bundle = Bundle;
            _Lubricant = Lubricant; _Process = Process; _Evoked = Evoked;
        }
        internal void Assing(Int32 id) => _ID = id;
        internal void Assign(DateTime date) => _Date = date;
        internal void Assign(Location location) => _Location = location;
        internal void Assing(Anesthetic anesthetic) => _Anesthetic = anesthetic;
        internal void Assing(Aphrodisiac aphrodisiac) => _Aphrodisiac = aphrodisiac;
        internal void Assign(Surgical surgical) => _Surgical = surgical;
        internal void Assign(Bundle bundle) => _Bundle = bundle;
        internal void Assign(Lubricant lubricant) => _Lubricant = lubricant;
        internal void Assign(Process process) => _Process = process;
        internal void Assign(Evoked evoked) => _Evoked = evoked;
        internal String JSON
        {
            get
            {
                return _ID.ToString();//返回完整JSON数据，各字段判空取默认值
            }
        }
        internal String Item
        {
            get
            {
                return _ID.ToString();//返回无头JSON数据，各字段判空取默认值                
            }
        }
    }
    internal class RecordElement
    {
        internal class Location
        {
            private readonly Int32 _ID;
            internal const String DefaultValue = @"{""Location"":{""ID"":199}}";
            internal Location(Int32 ID) { _ID = ID; }
            internal Int32 Item { get { return _ID; } }
            internal String JSON
            { get { return "{\"Location\":{" + $"\"ID\":{_ID}" + "}}"; } }
            // DefaultValue = @"{""Location"":{""ID"":199}}"
        }
        internal class Anesthetic
        {
            private readonly List<AnestheticItem> _Anesthetic;
            internal const String DefaultValue = @"{""Anesthetic"":[{""ID"":200,""Position"":900}]}";
            internal Anesthetic() { _Anesthetic = new(); }
            internal Int32 Count { get { return _Anesthetic.Count; } }
            internal void Add(Int32 ID, Int32 Position)
            { _Anesthetic.Add(new AnestheticItem(ID, Position)); }
            internal String JSON
            {
                get
                {
                    if (Count== 0) return DefaultValue;
                    else
                    {
                        String StringJSON = "{\"Anesthetic\":[";
                        foreach (AnestheticItem Element in _Anesthetic)
                            StringJSON += Element.Item + ",";
                        StringJSON += "]}";
                        StringJSON = StringJSON.Replace(",]", "]");
                        return StringJSON;
                    }                    
                }
            }
            // DefaultValue= @"{""Anesthetic"":[{""ID"":200,""Position"":900}]}"
        }
        private class AnestheticItem
        {
            private readonly Int32 _ID, _Position;
            internal AnestheticItem(Int32 ID, Int32 Position) { _ID = ID; _Position = Position; }
            internal Int32 ID { get { return _ID; } }
            internal Int32 Position { get { return _Position; } }
            internal String JSON
            { get { return "{\"AnestheticItem\":{" + $"\"ID\":{_ID},\"Position\":{_Position}" + "}}"; } }
            internal String Item { get { return "{" + $"\"ID\":{_ID},\"Position\":{_Position}" + "}"; } }
            // DefaultValue= @"{""AnestheticItem"":{""ID"":200,""Position"":900}}"
        }
        internal class Aphrodisiac
        {
            private readonly List<Int32> _ID;
            internal const String DefaultValue = @"{""Aphrodisiac"":[{""ID"":300}]}";
            internal Aphrodisiac() { _ID = new(); }
            internal Int32 Count { get { return _ID.Count; } }
            internal void Add(Int32 ID) { _ID.Add(ID); }
            internal String JSON
            {
                get
                {
                    if (Count == 0) return DefaultValue;
                    else
                    {
                        String StringJSON = "{\"Aphrodisiac\":[";
                        foreach (Int32 Element in _ID)
                            StringJSON += "{\"ID\":" + $"{Element}" + "},";
                        StringJSON += "]}";
                        StringJSON = StringJSON.Replace(",]", "]");
                        return StringJSON;
                    }                    
                }
            }
            // DefaultValue = @"{""Aphrodisiac"":[{""ID"":300}]}"
        }
        internal class Surgical
        {
            private readonly List<SurgicalItem> _Surgical;
            internal const String DefaultValue = @"{""Surgical"":[{""ID"":400,""Position"":900}]}";
            internal Surgical() { _Surgical = new(); }
            internal Int32 Count { get { return _Surgical.Count; } }
            internal void Add(Int32 ID, Int32 Position)
            { _Surgical.Add(new SurgicalItem(ID, Position)); }
            internal String JSON
            {
                get
                {
                    if (Count == 0) return DefaultValue;
                    else
                    {
                        String StringJSON = "{\"Surgical\":[";
                        foreach (SurgicalItem Element in _Surgical)
                            StringJSON += Element.Item + ",";
                        StringJSON += "]}";
                        StringJSON = StringJSON.Replace(",]", "]");
                        return StringJSON;
                    }                    
                }
            }
            // DefaultValue= @"{""Surgical"":[{""ID"":400,""Position"":900}]}"
        }
        private class SurgicalItem
        {
            private readonly Int32 _ID, _Position;
            internal SurgicalItem(Int32 ID, Int32 Position) { _ID = ID; _Position = Position; }
            internal Int32 ID { get { return _ID; } }
            internal Int32 Position { get { return _Position; } }
            internal String JSON
            { get { return "{\"SurgicalItem\":{" + $"\"ID\":{_ID},\"Position\":{_Position}" + "}}"; } }
            internal String Item { get { return "{" + $"\"ID\":{_ID},\"Position\":{_Position}" + "}"; } }
            // DefaultValue= @"{""SurgicalItem"":{""ID"":400,""Position"":900}}"
        }
        internal class Bundle
        {
            private readonly List<BundleItem> _Bundle;
            internal const String DefaultValue = @"{""Bundle"":[{""ID"":500,""Position"":900}]}";
            internal Bundle() { _Bundle = new(); }
            internal Int32 Count { get { return _Bundle.Count; } }
            internal void Add(Int32 ID, Int32 Position)
            { _Bundle.Add(new BundleItem(ID, Position)); }
            internal String JSON
            {
                get
                {
                    if (Count == 0) return DefaultValue;
                    else
                    {
                        String StringJSON = "{\"Bundle\":[";
                        foreach (BundleItem Element in _Bundle)
                            StringJSON += Element.Item + ",";
                        StringJSON += "]}";
                        StringJSON = StringJSON.Replace(",]", "]");
                        return StringJSON;
                    }                    
                }
            }
            // DefaultValue= @"{""Bundle"":[{""ID"":500,""Position"":900}]}"
        }
        private class BundleItem
        {
            private readonly Int32 _ID, _Position;
            internal BundleItem(Int32 ID, Int32 Position) { _ID = ID; _Position = Position; }
            internal Int32 ID { get { return _ID; } }
            internal Int32 Position { get { return _Position; } }
            internal String JSON
            { get { return "{\"BundleItem\":{" + $"\"ID\":{_ID},\"Position\":{_Position}" + "}}"; } }
            internal String Item { get { return "{" + $"\"ID\":{_ID},\"Position\":{_Position}" + "}"; } }
            // DefaultValue= @"{""BundleItem"":{""ID"":500,""Position"":900}}"
        }
        internal class Lubricant
        {
            private readonly List<Int32> _ID;
            internal const String DefaultValue = @"{""Lubricant"":[{""ID"":300}]}";
            internal Lubricant() { _ID = new(); }
            internal Int32 Count { get { return _ID.Count; } }
            internal void Add(Int32 ID) { _ID.Add(ID); }
            internal String JSON
            {
                get
                {
                    if (Count == 0) return DefaultValue;
                    else
                    {
                        String StringJSON = "{\"Lubricant\":[";
                        foreach (Int32 Element in _ID)
                            StringJSON += "{\"ID\":" + $"{Element}" + "},";
                        StringJSON += "]}";
                        StringJSON = StringJSON.Replace(",]", "]");
                        return StringJSON;
                    }
                }
            }
            // DefaultValue = @"{""Lubricant"":[{""ID"":300}]}"
        }
        internal class Process
        {
            private readonly List<ProcessItem> _Process;
            internal const String DefaultValue = @"{""Process"":[{""Posture"":799,""Action"":899,""Position"":999,""Note"":1000}]}";
            internal Process() { _Process = new(); }
            internal Int32 Count { get { return _Process.Count; } }
            internal void Add(Int32 Posture, Int32 Action, Int32 Position, Int32 Note)
            { _Process.Add(new ProcessItem(Posture, Action, Position, Note)); }
            internal String JSON
            {
                get
                {
                    if (Count == 0) return DefaultValue; 
                    else
                    {
                        String StringJSON = "{\"Process\":[";
                        foreach (ProcessItem Element in _Process)
                            StringJSON += Element.Item + ",";
                        StringJSON += "]}";
                        StringJSON = StringJSON.Replace(",]", "]");
                        return StringJSON;
                    }                    
                }
            }
            // DefaultValue = @"{""Process"":[{""Posture"":799,""Action"":899,""Position"":999,""Note"":1000}]}"
        }
        private class ProcessItem
        {
            private readonly Int32 _Posture, _Action, _Position, _Note;
            internal ProcessItem(Int32 Posture, Int32 Action, Int32 Position, Int32 Note)
            { _Posture = Posture; _Action = Action; _Position = Position; _Note = Note; }
            internal Int32 Posture { get { return _Posture; } }
            internal Int32 Action { get { return _Action; } }
            internal Int32 Position { get { return _Position; } }
            internal Int32 Note { get { return _Note; } }
            internal String JSON
            {
                get
                {
                    return "{\"ProcessItem\":{" + $"\"Posture\":{_Posture},\"Action\":" +
                        $"{_Action},\"Position\":{_Position},\"Note\":{_Note}" + "}}";
                }
            }
            internal String Item
            {
                get
                {
                    return "{" + $"\"Posture\":{_Posture},\"Action\":{_Action}," +
                        $"\"Position\":{_Position},\"Note\":{_Note}" + "}}";
                }
            }
            // DefaultValue = @"{""ProcessItem"":{""Posture"":799,""Action"":899,""Position"":999,""Note"":1000}}"
        }
        internal class Evoked
        {
            private readonly Int32 _Posture, _Action, _Position, _Note;
            internal Evoked(Int32 Posture, Int32 Action, Int32 Position, Int32 Note)
            { _Posture = Posture; _Action = Action; _Position = Position; _Note = Note; }
            internal Int32 Posture { get { return _Posture; } }
            internal Int32 Action { get { return _Action; } }
            internal Int32 Position { get { return _Position; } }
            internal Int32 Note { get { return _Note; } }
            internal String JSON
            {
                get
                {
                    return "{\"Evoked\":{" + $"\"Posture\":{_Posture},\"Action\":" +
                        $"{_Action},\"Position\":{_Position},\"Note\":{_Note}" + "}}";
                }
            }
            //DefaultValue = @"{""Evoked"":{""Posture"":799,""Action"":899,""Position"":999,""Note"":1000}}"
        }
    }
}
