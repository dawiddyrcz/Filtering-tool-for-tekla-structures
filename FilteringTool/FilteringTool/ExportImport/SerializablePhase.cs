/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;

namespace FilteringTool.ExportImport
{
    [Serializable]
    public class SerializablePhase : IComparable
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }

        public SerializablePhase() { }

        public SerializablePhase(Tekla.Structures.Model.Phase phase)
        {
            this.Number = phase.PhaseNumber;
            this.Name = phase.PhaseName;
            this.Comment = phase.PhaseComment;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            else
            {
                SerializablePhase phase = obj as SerializablePhase;

                if (this.Number <= phase.Number) return -1;
                else return 1;
            }
        }

    }
}
