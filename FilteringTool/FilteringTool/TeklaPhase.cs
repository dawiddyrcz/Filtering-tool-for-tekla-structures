/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using Tekla.Structures.Model;

namespace FilteringTool
{
    /// <summary>This class allow to handle the Tekla Strucutes Phase in the model. You can create new phase, get phase informations, 
    /// set current phase or delete phase. You cant also use this class to move model parts between phases</summary>
    public class TeklaPhase : IComparable
    {
        private Phase phase;

        public TeklaPhase()
        {
            phase = new Phase();
        }

        public TeklaPhase(Phase Phase)
        {
            this.phase = Phase;
        }

        public TeklaPhase(Phase Phase, bool ShortDescription)
        {
            this.phase = Phase;
            this.ShortDescription = ShortDescription;
        }

        public TeklaPhase(int phaseNumber, string phaseName)
        {
            phase = new Phase()
            {
                PhaseNumber = phaseNumber,
                PhaseName = phaseName
            };
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            else
            {
                TeklaPhase phase = obj as TeklaPhase;

                if (this.GetNumber() <= phase.GetNumber()) return -1;
                else return 1;
            }
        }

        /// <returns>Phase number</returns>
        public int GetNumber() => phase.PhaseNumber;

        /// <summary>Inserts this phase to the opened tekla structures model</summary><returns>True if success</returns>
        public bool Insert() => phase.Insert();

        /// <summary>ToString() method can return short desctiption of the phase contains only phase number</summary>
        public bool ShortDescription = false;

        public override string ToString()
        {
            if (!ShortDescription)
            {
                if (phase.IsCurrentPhase == 1)
                {
                    return "@" + phase.PhaseNumber + "  " + phase.PhaseName + "   @ current phase";
                }
                else
                {
                    return "" + phase.PhaseNumber + "  " + phase.PhaseName;
                }
            }
            else
            {
                return "" + phase.PhaseNumber;
            }
        }

        /// <summary>Sets this phase as current phase in the model</summary>
        public void SetCurrent()
        {
            this.phase.IsCurrentPhase = 1;
            this.phase.Modify();
        }

        /// <summary>Iterates through selected object in the model and move its to this phase</summary>
        /// <returns>The number of moved objects</returns>
        public int MoveSelectedObjectsToPhase()
        {
            var selectedObjects = new Tekla.Structures.Model.UI.ModelObjectSelector().GetSelectedObjects();
            while (selectedObjects.MoveNext())
            {
                selectedObjects.Current.SetPhase(this.phase);
            }
            return selectedObjects.GetSize();
        }

    }

}
