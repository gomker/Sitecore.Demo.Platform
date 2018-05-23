# Introduction 
HabitatHome  Demo and the tools and processes in it is a Sitecore&reg; solution example built using Sitecore Experience Accelerator&trade; (SXA) on Sitecore Experience Platform&trade; (XP)  following the Helix architecture principles.


# Important Notice

### License
Please read the LICENSE carefully prior to using the code in this repository
 
### Support

The code, samples and/or solutions provided in this repository are ***unsupported by Sitecore PSS***. Support is provided on a best-effort basis via GitHub issues or Slack #habitathome (see end of README for additional information).

It is assumed that you already have a working instance of Sitecore XP and all prerequisites prior to installing the demo. Support for **product installation** issues should be directed to relevant Community channels or through regular Sitecore support channels. 

### Warranty

The code, samples and/or solutions provided in this repository are for example purposes only and **without warranty (expressed or implied)**. The code has not been extensively tested and is not guaranteed to be bug free.  

# Getting Started

## Prerequisites

### Sitecore Version

Prior to attempting the demo installation, ensure you have a working **Sitecore XP 9.0.1** instance. Detailed installation instructions can be found at [doc.sitecore.com](https://dev.sitecore.net/Downloads/Sitecore_Experience_Platform/90/Sitecore_Experience_Platform_90_Update1.aspx).

### Additional modules
In addition to a base XP 9.0.1 installation, the following modules are required:

- Sitecore PowerShell Extensions 4.7.2 for Sitecore 8/9 on [Marketplace](https://marketplace.sitecore.net/services/~/download/3D2CADDAB4A34CEFB1CFD3DD86D198D5.ashx?data=Sitecore%20PowerShell%20Extensions-4.7.2%20for%20Sitecore%208&itemId=6aaea046-83af-4ef1-ab91-87f5f9c1aa57)
- Sitecore Experience Accelerator for 9.0 versionn 1.6 on [dev.sitecore.com](https://dev.sitecore.net/en/Downloads/Sitecore_Experience_Accelerator/16/Sitecore_Experience_Accelerator_16_Initial_Release.aspx)
- Data Exchange Framework v2.0.1 on [dev.sitecore.com](https://dev.sitecore.net/Downloads/Data_Exchange_Framework/2x/Data_Exchange_Framework_201.aspx) as well as relevant Providers on same page
	- Sitecore Provider for Data Exchange Framework 2.0.1
	- SQL Provider for Data Exchange Framework 2.0.1
	- xConnect Provider for Data Exchange Framework 2.0.1 
- Data Exchange Framework 2.0.1 Dynamics Connectors on [dev.sitecore.com](https://dev.sitecore.net/Downloads/Dynamics_CRM_Connect/2x/Sitecore_Connect_for_Microsoft_Dynamics_365_for_Sales_201.aspx)
	- Microsoft Dynamics 365 for Sales Provider for Data Exchange Framework 2.0.1
	- Sitecore Connect for Microsoft Dynamics 365 for Sales 2.0.1

### Build / Deployment

In order to deploy the assets, you need either Visual Studio 2017 or MSBuild Tools for Visual Studio 2017.

Node.JS is also required



### Custom install - before you start

The following is a list of default values / assumptions for install locations

**Project location**		`c:\projects\sitecore.habitathome.content\`
**Habitat Site domain**				`habitathome.dev.local`
**Web Root**						`c:\inetpub\wwwroot`
**Host Suffix**						`dev.local`

#### The hostname habitathome.dev.local is used in the SXA Hostname (Site Grouping). 

If you do not use habitathome.dev.local you will need to modify the Host Name in 
`/sitecore/content/Habitat Sites/Habitat Home/Settings/Site Grouping/Habitat Home` after successfully deploying the site.
The Habitat Home site will not respond / render correctly until this value is modified. 

If you do **not want to use the default settings**, you need to adjust the appropriate values in the following files:

`/gulp-config..js` 
`/publishsettings.targets` 
`src\Project\Common\code\App_Config\Include\Project\z.Common.Website.DevSettings.config`


## Installation:

All installation instructions assume using PowerShell 5.1 in administrative mode.

### 1 Clone this repository

#### Setting Git for Long Paths

- Before cloning, you need to configure git to allow long paths, which is not the default.

`git config --system core.longpaths true`

Clone the Sitecore.HabitatHome.Content repository locally - defaults are configured for **C:\Projects\Sitecore.HabitatHome.Content**. 


- Clone 
-- **https**:	`git clone https://github.com/Sitecore/Sitecore.HabitatHome.Content.git` 
-- **ssh**:		`git clone git@github.com:Sitecore/Sitecore.HabitatHome.Content.git`

### 2 Deploy Sitecore.HabitatHome.Content

From the root of the solution
- Run **`npm install`**

**if you plan on installing the Commerce (XC) demo:**
- Run **`.\node_modules\.bin\gulp quick-deploy`** 

if you are only installing this demo:
- Run **`.\node_modules\.bin\gulp initial`**

> gulp **initial** only needs to be executed successfully during the initial deployment. Subsequent deployments can be made by running the default gulp task (gulp with no parameters). 

> An error (maxBuffer) sometimes occurs the first time running gulp during Sync-Unicorn. 
> Running gulp a second time resolves the issue (and doesn't take as long)


# Contribute or Issues
Please post any issues on Slack Community [#habitathome](https://sitecorechat.slack.com/messages/habitathome/) channel or create an issue on [GitHub](https://github.com/Sitecore/Sitecore.HabitatHome.Content/issues). Contributions are always welcome!
