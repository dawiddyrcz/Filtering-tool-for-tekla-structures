/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using Tekla.Structures.Filtering;
using Tekla.Structures.Filtering.Categories;

namespace FilteringTool
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("", "IDE0028")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("", "IDE0019")]
    /// <summary>Selects all objects which are on the phase</summary>
    internal class PhaseObjectSelector
    {
        /// <summary>Selects all objects which are on the phase</summary>
        /// <param name="phaseNumber">Number of the phase</param>
        /// <exception cref="Exceptions.FilteringToolTeklaSettingsException">When macro directory not exsists</exception>
        public static void SelectObjects(int phaseNumber)
        {
            var assemblyPhase = new TemplateFilterExpressions.CustomString("ASSEMBLY.PHASE");
            var phase = new StringConstantFilterExpression(phaseNumber.ToString());
            var expresion1 = new BinaryFilterExpression(assemblyPhase, StringOperatorType.IS_EQUAL, phase);

            var objectType = new ObjectFilterExpressions.Type();
            var partF = new NumericConstantFilterExpression(Tekla.Structures.TeklaStructuresDatabaseTypeEnum.PART);
            var expresion2 = new BinaryFilterExpression(objectType, NumericOperatorType.IS_EQUAL, partF);

            var expresion = new BinaryFilterExpressionCollection();
            expresion.Add(new BinaryFilterExpressionItem(expresion1, BinaryFilterOperatorType.BOOLEAN_AND));
            expresion.Add(new BinaryFilterExpressionItem(expresion2, BinaryFilterOperatorType.BOOLEAN_AND));

            var filter = new Filter(expresion);

            var objects = new Tekla.Structures.Model.Model().GetModelObjectSelector().GetObjectsByFilter(expresion);
            objects.SelectInstances = false;

            var ar = new System.Collections.ArrayList();

            while (objects.MoveNext())
            {
                var part = objects.Current as Tekla.Structures.Model.Part;
                if (part != null)
                {
                    var assembly = part.GetAssembly();
                    ar.Add(assembly);
                    break;
                }
            }

            var mos = new Tekla.Structures.Model.UI.ModelObjectSelector();
            mos.Select(new System.Collections.ArrayList());
            mos.Select(ar);

            if (Tekla.Structures.TeklaStructures.Connect())
            {
                TeklaMacroDirectory.CheckIfExists();
                var akit = new Tekla.Structures.MacroBuilder();

                akit.PushButton("butCancel", "diaPhaseManager");
                akit.Callback("acmd_display_active_system_dialog", "", "main_frame");
                akit.PushButton("butSelectPhases", "diaPhaseManager");
                akit.PushButton("butSelectObjects", "diaPhaseManager");
                akit.PushButton("butCancel", "diaPhaseManager");

                akit.Run();
                akit = null;
            }
        }
    }
}
