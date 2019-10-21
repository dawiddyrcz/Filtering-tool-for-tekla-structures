/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System.Collections.Generic;
using TSD = Tekla.Structures.Drawing;
using TSM = Tekla.Structures.Model;

namespace FilteringTool
{
    /// <summary>Filtering tool allow to change view and selection filters in opened tekla structures model. 
    /// Filters are based on phases</summary>
    public class FilteringToolClass
    {
        TSM.Model model = new TSM.Model();
        SelectionFilter selectionFilter = new SelectionFilter();
        ViewFilter viewFilter = new ViewFilter();

        /// <summary>Checks if drawing editor is opened</summary>
        /// <returns>True if any drawing is opened</returns>
        public bool IsDrawingOpened()
        {
            var drawingHandler = new TSD.DrawingHandler();
            return drawingHandler.GetActiveDrawing() != null;
        }

        /// <summary>Checks if tekla strucutres model is opened</summary>
        /// <returns>True if opened</returns>
        public bool IsModelOpened()
        {
            return model.GetConnectionStatus();
        }

        /// <summary>Sets selection filter based on model phases in opened tekla structures model</summary>
        /// <param name="phases">List of phase numbers</param>
        public void SetSelectionFilter(List<int> phases)
        {
            selectionFilter.PhasesToFilter.Clear();
            if (phases.Count == 0)
            {
                selectionFilter.SetStandardSelectionFilter();
            }
            else
            {
                selectionFilter.PhasesToFilter.AddRange(phases);
                selectionFilter.SetCurrentSelectionFilter();
            }

        }

        /// <summary>Sets view filter based in model phases of all views in opened tekla structures model</summary>
        /// <param name="phases">List of phase numbers</param>
        public void SetViewFilterOfAllViews(List<int> phases)
        {
            viewFilter.PhasesToFilter.Clear();
            viewFilter.PhasesToFilter.AddRange(phases);
            viewFilter.SetViewFilterOfAllViews();
        }

        /// <summary>Sets view filter based in model phases of only selected views in opened tekla structures model</summary>
        /// <param name="phases">List of phase numbers</param>
        public void SetViewFilterOfSelectedViews(List<int> phases)
        {
            viewFilter.PhasesToFilter.Clear();
            viewFilter.PhasesToFilter.AddRange(phases);
            viewFilter.SetViewFilterOfSelectedViews();
        }

        /// <summary>Sets display filter on the selected views</summary>
        /// <param name="viewDisplay">Data with display settings</param>
        public void SetViewDisplayOfSelectedViews(ViewDisplay viewDisplay)
        {
            viewDisplay.SetDisplayOfSelectedViews();
        }

        /// <summary>Gets all model phases from the opened tekla strucutres model</summary>
        /// <returns>List of TeklaPhase objects</returns>
        public List<TeklaPhase> GetTeklaPhases()
        {
            var retList = new List<TeklaPhase>();
            var phaseCollection = model.GetPhases();
            foreach (TSM.Phase phase in phaseCollection)
            {
                var teklaPhase = new TeklaPhase(phase);
                retList.Add(teklaPhase);
            }
            return retList;
        }

        /// <summary>Selects all model views in opened tekla strucutres model</summary>
        public void SelectAllModelViews()
        {
            ModelViews.SelectAllModelViews();
        }

        /// <summary>Sets current phase in the opened tekla strucutres model</summary>
        /// <param name="phaseNumber">Number of the phase</param>
        public void SetCurrentPhase(int phaseNumber)
        {
            var phase = GetPhaseByNumber(phaseNumber);
            phase.IsCurrentPhase = 1;
            phase.Modify();
            model.CommitChanges();
        }

        /// <summary>Move all selected model bojects to the phase with phaseNumber</summary>
        /// <param name="phaseNumber">Number of phase</param>
        /// <returns>Numbers of moved objects</returns>
        public int MoveSelectedObjectsToPhase(int phaseNumber)
        {
            var selectedObjects = new Tekla.Structures.Model.UI.ModelObjectSelector().GetSelectedObjects();
            if (selectedObjects.GetSize() == 0) return 0;

            var phase = GetPhaseByNumber(phaseNumber);

            while (selectedObjects.MoveNext())
            {
                selectedObjects.Current.SetPhase(phase);
            }
            return selectedObjects.GetSize();
        }

        private Tekla.Structures.Model.Phase GetPhaseByNumber(int phaseNumber)
        {
            var retPhase = new Tekla.Structures.Model.Phase();
            var phaseCollection = model.GetPhases();
            foreach (TSM.Phase phase in phaseCollection)
            {
                if (phase.PhaseNumber.Equals(phaseNumber))
                {
                    retPhase = phase;
                    break;
                }
            }
            return retPhase;
        }
    }
}
