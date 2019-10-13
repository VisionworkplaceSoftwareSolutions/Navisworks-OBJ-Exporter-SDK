Navisworks to OBJ SDK Setup:
1. Clone the repo.
2. Open readme.md. And download the dependent dlls from the mentioned link.
3. Add referance of above dependent dlls in your project using Project->Referancea->Add Referance...
4. Add this code snippet to your .cs file,
	---------------------------------------
	//Setting Apis
    Visionworkplace_Navisworks_OBJ.Settings.getSettings.Y_Z_Flip = true;
    Visionworkplace_Navisworks_OBJ.Settings.getSettings.ShowMessageBox = false;
    Visionworkplace_Navisworks_OBJ.Settings.getSettings.ExportSelecterEntities = false;
    Visionworkplace_Navisworks_OBJ.Settings.getSettings.Properties = true;
	
	//Navisworks to OBJ Export Apis
	//Create the object of 'VisionworkplaceOBJ' class and the call 'ConvertToOBJ' function
	Visionworkplace_Navisworks_OBJ.VisionworkplaceOBJ objConverter = new Visionworkplace_Navisworks_OBJ.VisionworkplaceOBJ();
    objConverter.ConvertToOBJ("E:\\Test\\Navisworks_OBJ.obj"); 
	---------------------------------------
For any other information, please visit our website: www.visionworkplace.com, or contact support@visionworkplace.com.

The dependent dlls need license. It will come with 10 days trial to evaluate the SDK. For license, please contact at support@visionworkplace.com.
