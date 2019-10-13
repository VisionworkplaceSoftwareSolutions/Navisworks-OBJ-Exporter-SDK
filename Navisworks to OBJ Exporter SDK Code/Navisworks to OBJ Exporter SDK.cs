
/***********************************************************
* Step 1: Download the dependent dlls from the mentioned link.
* Add referance of above dependent dlls in your project using Project->Referancea->Add Referance...
**********************************************************/

/***********************************************************
* Step 2: Create the object of 'VisionworkplaceOBJ' class and the call 'ConvertToOBJ' function
**********************************************************/
//Setting Apis
    Visionworkplace_Navisworks_OBJ.Settings.getSettings.Y_Z_Flip = true;
    Visionworkplace_Navisworks_OBJ.Settings.getSettings.ShowMessageBox = false;
    Visionworkplace_Navisworks_OBJ.Settings.getSettings.ExportSelecterEntities = false;
    Visionworkplace_Navisworks_OBJ.Settings.getSettings.Rotate = true;
    Visionworkplace_Navisworks_OBJ.Settings.getSettings.Properties = false;

//Navisworks to OBJ Export Apis.
    Visionworkplace_Navisworks_OBJ.VisionworkplaceOBJ objConverter = new Visionworkplace_Navisworks_OBJ.VisionworkplaceOBJ();
    objConverter.ConvertToOBJ("E:\\Test\\Navisworks_OBJ.obj");
