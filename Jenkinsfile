// Powered by Infostretch 

timestamps {

node () {

	stage ('DemoProject-dotnet - Checkout') {
 	 checkout([$class: 'GitSCM', branches: [[name: '*/master']], doGenerateSubmoduleConfigurations: false, extensions: [], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '268b9d64-9d39-4556-afeb-f40f86f6d8e1', url: 'https://github.com/pjl-pranjal/Demo-Project']]]) 
	}
	stage ('DemoProject-dotnet - Build') {
 			// Shell build step
sh """ 
export PATH=/usr/local/share/dotnet:$PATH
dotnet msbuild 
 """ 
	}
}
}