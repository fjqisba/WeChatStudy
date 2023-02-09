#pragma once
#include <string>

//插件_开启页面相关功能
void PLUGIN_H5Web();

std::string DoH5Transfer(std::string& cmdIndex, std::string& url, const std::string& api, std::string& reqJson, unsigned int cgi_cmdid,
	const std::string& scope, unsigned int is_security_check);
