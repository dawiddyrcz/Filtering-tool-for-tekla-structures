/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using Tekla.Structures.Model;
using System.IO;

namespace FilteringTool.ExportImport
{
    class PhaseExporter
    {
        ///<exception cref="Exceptions.FilteringToolException"></exception>
        public void ExportPhases(string fileName, SerializablePhaseCollection modelPhases)
        {
            try
            {
                if (modelPhases.GetSize() > 0)
                {
                    modelPhases.Save(fileName);
                }
            }
            catch (Exception ex)
            {
                string message = "Could not export phases to file: " + Path.GetFileName(fileName);
                message = message + "\n\n" + Exceptions.IOExceptionsHandler.GetMessage(ex);

                throw new Exceptions.FilteringToolException(message, ex);
            }
        }

        public SerializablePhaseCollection GetPhasesFromModel()
        {
            var model = new Model();
            var modelPhases = new SerializablePhaseCollection();
            var phases = model.GetPhases();

            foreach (Phase phase in phases)
            {
                var serializablePhase = new SerializablePhase(phase);
                modelPhases.Add(serializablePhase);
            }

            modelPhases.Sort();

            return modelPhases;
        }
    }
}
