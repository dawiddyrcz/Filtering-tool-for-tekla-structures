/* Copyright © 2018 Dawid Dyrcz */
/* See license file */

using System;
using Tekla.Structures;

namespace FilteringTool
{
    /// <summary>Sets display filter to the tekla structures model views. 
    /// Display filter is the filter of object visibility like: points, bolts, component symbols, cuts fittings etc. 
    /// In opened Tekla Structures double click on the view. Open view menu > Display settings. 
    /// </summary>
    public class ViewDisplay
    {
        public bool Points { get; set; } = false;

        public bool PartsInModel { get; set; } = true;
        public bool PartsInComponents { get; set; } = true;

        public bool BoltsInModel { get; set; } = true;
        public bool BoltsInComponents { get; set; } = true;
        public bool HolesInModel { get; set; } = true;
        public bool HolesInComponents { get; set; } = true;
        public bool WeldsInModel { get; set; } = false;
        public bool WeldsInComponents { get; set; } = false;

        public bool ConstructionPlanesInModel { get; set; } = false;
        public bool ConstructionPlanesInComponents { get; set; } = false;
        public bool ReinforcingBarsInModel { get; set; } = true;
        public bool ReinforcingBarsInComponents { get; set; } = true;
        public bool SurfaceTreatmentAndSurfaces { get; set; } = true;
        public bool PourBreaks { get; set; } = true;
        public bool Loads { get; set; } = true;

        public bool CutsAndAddedMaterialsInModel { get; set; } = false;
        public bool CutsAndAddedMaterialsInComponents { get; set; } = false;
        public bool FittingsInModel { get; set; } = false;
        public bool FittingsInComponents { get; set; } = false;

        public bool ComponentSymbolsInModel { get; set; } = false;
        public bool ComponentSymbolsInComponents { get; set; } = false;

        public bool Grids { get; set; } = true;
        public bool ConstructionLines { get; set; } = false;
        public bool ReferenceObjects { get; set; } = true;

        ///<summary>Sets display filter to the all selected views in the opened tekla strucutes model</summary>
        ///<exception cref="Exceptions.FilteringToolException"></exception>
        public void SetDisplayOfSelectedViews()
        {
            if (Drawing.IsNotOpened())
            {
                if (TeklaStructures.Connect())
                {
                    try
                    {
                        TeklaMacroDirectory.CheckIfExists();
                        var macro = new MacroBuilder();
                        CreateMacro(ref macro);
                        macro.Run();
                        macro = null;
                    }
                    catch (Exception ex)
                    {
                        string message = "Cannot change display settings";
                        message = message + "\n\n" + Exceptions.IOExceptionsHandler.GetMessage(ex);
                        throw new Exceptions.FilteringToolException(message, ex);
                    }
                }
            }
        }

        private void CreateMacro(ref MacroBuilder akit)
        {
            akit.Callback("acmd_display_selected_object_dialog", "", "main_frame");
            akit.PushButton("v1_show", "dia_view_dialog");

            akit.ValueChange("Modelling view setup", "sd_points", IntStr(this.Points));
            akit.ValueChange("Modelling view setup", "sd_parts", IntStr(this.PartsInModel));
            akit.ValueChange("Modelling view setup", "sd_joint_parts", IntStr(this.PartsInComponents));
            akit.ValueChange("Modelling view setup", "sd_screws", IntStr(this.BoltsInModel));
            akit.ValueChange("Modelling view setup", "sd_joint_screws", IntStr(this.BoltsInComponents));
            akit.ValueChange("Modelling view setup", "sd_holes", IntStr(this.HolesInModel));
            akit.ValueChange("Modelling view setup", "sd_joint_holes", IntStr(this.HolesInComponents));
            akit.ValueChange("Modelling view setup", "sd_weldings", IntStr(this.WeldsInModel));
            akit.ValueChange("Modelling view setup", "sd_joint_weldings", IntStr(this.WeldsInComponents));
            akit.ValueChange("Modelling view setup", "chkButUserPlaneVisibility", IntStr(this.ConstructionPlanesInModel));
            akit.ValueChange("Modelling view setup", "chkButUserPlaneVisibInJoints", IntStr(this.ConstructionPlanesInComponents));
            akit.ValueChange("Modelling view setup", "chkButRebarVisibility", IntStr(this.ReinforcingBarsInModel));
            akit.ValueChange("Modelling view setup", "chkButRebarVisibilityInJoints", IntStr(this.ReinforcingBarsInComponents));
            akit.ValueChange("Modelling view setup", "chkButSurfacingVisibility", IntStr(this.SurfaceTreatmentAndSurfaces));
            akit.ValueChange("Modelling view setup", "chkButPourBreakVisibility", IntStr(this.PourBreaks));
            akit.ValueChange("Modelling view setup", "chkButLoadVisibility", IntStr(this.Loads));
            akit.ValueChange("Modelling view setup", "sd_cuts", IntStr(this.CutsAndAddedMaterialsInModel));
            akit.ValueChange("Modelling view setup", "sd_joint_cuts", IntStr(this.CutsAndAddedMaterialsInComponents));
            akit.ValueChange("Modelling view setup", "sd_fittings", IntStr(this.FittingsInModel));
            akit.ValueChange("Modelling view setup", "sd_joint_fittings", IntStr(this.FittingsInComponents));
            akit.ValueChange("Modelling view setup", "sd_joint_symbols", IntStr(this.ComponentSymbolsInModel));
            akit.ValueChange("Modelling view setup", "sd_joint_joint_symbols", IntStr(this.ComponentSymbolsInComponents));
            akit.ValueChange("Modelling view setup", "sd_grids", IntStr(this.Grids));
            akit.ValueChange("Modelling view setup", "sd_construction_lines", IntStr(this.ConstructionLines));
            akit.ValueChange("Modelling view setup", "sd_reference_models", IntStr(this.ReferenceObjects));
            akit.PushButton("sd_ok", "Modelling view setup");

            akit.ValueChange("dia_view_dialog", "v1_name_enable", "0");
            akit.ValueChange("dia_view_dialog", "v1_perspective_enable", "0");
            akit.ValueChange("dia_view_dialog", "v1_projection_enable", "0");
            akit.ValueChange("dia_view_dialog", "v1_rotate_z_enable", "0");
            akit.ValueChange("dia_view_dialog", "v1_rotate_x_enable", "0");
            akit.ValueChange("dia_view_dialog", "ViewUpdateRepresentationEnable", "0");
            akit.ValueChange("dia_view_dialog", "v1_depth_up_enable", "0");
            akit.ValueChange("dia_view_dialog", "v1_depth_down_enable", "0");
            akit.ValueChange("dia_view_dialog", "v1_filter_enable", "0");
            akit.ValueChange("dia_view_dialog", "v1_show_enable", "1");
            akit.PushButton("v1_modify", "dia_view_dialog");
            akit.PushButton("v1_ok", "dia_view_dialog");
        }

        private string IntStr(bool value)
        {
            if (value) return 1.ToString();
            else return 0.ToString();
        }
    }
}
