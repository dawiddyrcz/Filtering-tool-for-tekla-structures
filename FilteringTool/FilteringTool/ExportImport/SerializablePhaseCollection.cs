/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FilteringTool.ExportImport
{
    [Serializable]
    public class SerializablePhaseCollection
    {
        public List<SerializablePhase> List { get; set; } = new List<SerializablePhase>();

        public void Add(SerializablePhase serializablePhase) => this.List.Add(serializablePhase);

        public void Clear() => this.List.Clear();

        public int GetSize() => this.List.Count;

        public void Sort() => this.List.Sort();

        /// <summary> Saves to an xml file</summary>
        /// <param name="FileName">File path of the new xml file</param>
        public void Save(string FileName)
        {
            using (var writer = new System.IO.StreamWriter(FileName))
            {
                var serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(writer, this);
                writer.Flush();
            }
        }

        /// <summary> Load an object from an xml file</summary>
        /// <param name="FileName">Xml file name</param>
        /// <returns>The object created from the xml file</returns>
        public static SerializablePhaseCollection Load(string FileName)
        {
            using (var stream = System.IO.File.OpenRead(FileName))
            {
                var serializer = new XmlSerializer(typeof(SerializablePhaseCollection));
                return serializer.Deserialize(stream) as SerializablePhaseCollection;
            }
        }
    }
}
