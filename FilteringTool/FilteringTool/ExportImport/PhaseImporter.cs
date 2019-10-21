/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using System.Collections.Generic;
using System.IO;
using Tekla.Structures.Model;

namespace FilteringTool.ExportImport
{
    class PhaseImporter
    {
        ///<exception cref="Exceptions.FilteringToolException"></exception>
        public SerializablePhaseCollection LoadPhasesFromFile(string fileName)
        {
            try
            {
                var phasesFromFile = SerializablePhaseCollection.Load(fileName);
                phasesFromFile.Sort();
                return phasesFromFile;
            }
            catch (Exception ex)
            {
                string message = "Could not load phases from file: " + Path.GetFileName(fileName);
                message = message + "\n\n" + Exceptions.IOExceptionsHandler.GetMessage(ex);

                throw new Exceptions.FilteringToolException(message, ex);
            }

        }

        public SerializablePhaseCollection GetPhasesFromModel()
        {
            var phasesFromModel = new SerializablePhaseCollection();
            var phases = new Model().GetPhases();
            foreach (Phase phase in phases)
            {
                var serializablePhase = new SerializablePhase(phase);
                phasesFromModel.Add(serializablePhase);
            }
            phasesFromModel.Sort();
            return phasesFromModel;
        }

        public SerializablePhaseCollection GetConflicts(SerializablePhaseCollection phasesFromFile, SerializablePhaseCollection phasesFromModel)
        {
            var conflicts = new SerializablePhaseCollection();

            foreach (var phaseFromFile in phasesFromFile.List)
            {
                int phaseInModelIndex = phasesFromModel.List.FindIndex(p => p.Number.Equals(phaseFromFile.Number));
                if (phaseInModelIndex >= 0)
                {
                    var phaseInModelWithSameNumber = phasesFromModel.List[phaseInModelIndex];

                    if (phaseInModelWithSameNumber.Name.Equals(phaseFromFile.Name) == false |
                        phaseInModelWithSameNumber.Comment.Equals(phaseFromFile.Comment) == false)
                    {
                        conflicts.Add(phaseFromFile);
                    }
                }
            }

            return conflicts;
        }

        public void InsertOrModifyPhasesInTekla(SerializablePhaseCollection serializablePhaseCollection)
        {
            foreach (var serializablePhases in serializablePhaseCollection.List)
            {
                var modelPhase = GetPhaseFromModel(serializablePhases.Number);
                if (modelPhase == null)
                {
                    modelPhase = new Phase
                    {
                        PhaseNumber = serializablePhases.Number,
                        PhaseName = serializablePhases.Name,
                        PhaseComment = serializablePhases.Comment
                    };
                    modelPhase.Insert();
                }
                else
                {
                    modelPhase.PhaseNumber = serializablePhases.Number;
                    modelPhase.PhaseName = serializablePhases.Name;
                    modelPhase.PhaseComment = serializablePhases.Comment;
                    modelPhase.Modify();
                }
            }

            new Model().CommitChanges();
        }

        List<Phase> phasesInModel;
        private Phase GetPhaseFromModel(int number)
        {
            if (phasesInModel == null) phasesInModel = GetPhaseListFromModel();
            int findedIndex = phasesInModel.FindIndex(p => p.PhaseNumber.Equals(number));

            if (findedIndex >= 0)
                return phasesInModel[findedIndex];
            else
                return null;
        }

        private List<Phase> GetPhaseListFromModel()
        {
            var retList = new List<Phase>();
            var phases = new Model().GetPhases();
            foreach (Phase phase in phases)
            {
                retList.Add(phase);
            }
            return retList;
        }
    }
}
