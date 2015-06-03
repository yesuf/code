
// GoTo URL
function goto(url)
{
    window.location = url;
}

// ShowStatus
function S(obj)
	{
		D(obj.innerText);
	}


// ClearStatus
function C()
	{
	D("");
	}

// EscapeAndAppendToUrl
function EA(strUrl, strName, strValue)
	{
	if (-1 == strUrl.indexOf('?'))
		strUrl += '?';
	else
		strUrl += '&';

	return strUrl + strName + '=' + escape(strValue);
	}

// DisplayInStatus
function D(str)
{
	str = str.replace(/"/g, "''");
	window.status = str;
	setTimeout('window.status = "' + str + '";', 0);
	setTimeout('window.status = "' + str + '";', 1);
}


function StrGetPagingBase()
	{
	// This is stupid - the string specified by document.location doesn't
	// have a lengthed defined! To compensate, I make sure javascript
	//  generates a new string by appending an empty string to the end.
	var strBase = document.location + "";
	var cPeriodCount = 0;
	var i;

	for (var i = strBase.length - 1; i >= 0 && cPeriodCount < 2; i--)
		{
		var strCurrent = strBase.substr(i, 1);

		if ("." == strCurrent)
			cPeriodCount++;
		}

	if (2 != cPeriodCount)
		return "";

	return strBase.substring(0, i + 2);
	}

	
function GoToPage(iPage)
{
	window.location = StrGetPagingBase() + iPage + ".xml";
}


function SetNamespace(strNamespace)
	{
	g_strNamespace = strNamespace;

	if (g_strNamespace.substr(g_strNamespace.length - 1) != '/')
		g_strNamespace += '/';

	}


// Removes any attempts at opening or closing a tag from a string.
function StrFixString(strString)
	{
	if (null == strString)
		return null;

	strString = strString.replace(/</g, "&lt;");
	return strString.replace(/>/g, "&gt;");
	}


function SzGetArgumentValue(strQueryName)
	{
	var reQuery = new RegExp("[\\?&]" + strQueryName + "=([^&]*)", "i");

	if (!reQuery.test(location))
		return null;

	return reQuery.exec(location)[0].substring(strQueryName.length + 2);
	}


function defined(obj)
	{
	return !(typeof(obj) == "undefined");
	}
	


function GoOffline()
	{
	if (defined(window.external.GoOffline))
		window.external.GoOffline();
	}