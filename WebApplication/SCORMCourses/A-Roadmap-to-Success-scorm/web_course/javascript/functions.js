var pages = new Array(
	  "Screen01"
	, "Screen02"
	, "Screen03"
	, "Screen03a"
	, "Screen04"
	, "Screen05"
	, "Screen06"
	, "Screen07"
	, "Screen08"
	, "Screen09"
	, "Screen10"
	, "Screen11"
	, "Screen12"
	, "Screen13"
	, "Screen14"
	, "Screen15"
	, "Screen16"
	, "Screen17"
	, "Screen18"
	, "Screen19"
	, "Screen20"
	, "Screen21"
	, "Screen22"
	, "Screen23"
	, "Screen24"
	, "Screen25"
	, "Screen26"
	, "Screen27"
	, "Screen28"
	, "Screen29"
	, "Screen30"
	, "Screen31"
	, "Screen32"
	, "Screen33"
	, "Screen34"
	, "Screen35"
	, "Screen36"
	, "Screen37"
	, "Screen38"
	, "Screen39"
	, "Screen40"
	, "Screen41"
	, "Screen42"
	, "Screen43"
	, "Screen44"
	, "Screen45"
	, "Screen46"
	, "Screen47"
	, "Screen48"
	, "Screen49"
	, "Screen50"
	, "Screen51"
	, "Screen52"
	, "Screen53"
	, "Screen54"
	, "Screen55"
);

pages.unshift("index");
pages.push("index");


// ------------- NAVIGATION -------------

var debug = false;

var moduleNum = 0;
var pageNum = 0;
var pageNext = "";
var pageBack = "";
var nextActive = true;
var backActive = true;
var pageIndex;
var pageName = document.location.href;
pageName = pageName.substring(pageName.lastIndexOf("/") + 1);  // remove all path info, leaving filename
if (pageName.indexOf("cf~") != -1)
	pageName = pageName.substring(3);  // remove CF development tag
pageName = pageName.substring(0, pageName.indexOf("."));  // remove .htm
if (pageName == "") pageName = "index";

function writeProgress() {
	var n = pages.length - 2;
	document.getElementById("progressText").innerHTML = "Progress " + pageNum + " of " + n;
	document.getElementById("progressBar").style.width = (pageNum / n * 100).toString() + "px";
}

var i;
var popWin = null;
var fbWin = null;
var pageViewedList, pageNameArray;

pageNum = 0;
for (i = 0; i < pages.length; i++) {
	if (pages[i] == pageName) {
		pageIndex = i;
		pageNum = pageIndex;
		break;
	}
}

function pageLoaded() {
	doLoadNavVars();

	if (!backActive) {
		document.getElementById("btnBack").style.backgroundPosition = "left 0px";
		document.getElementById("btnBack").title = "Back (inactive)";
	}
	if (!nextActive && window.opener != null) {
		if (opener.pageTrack.indexOf("|" + pageName + "|") != -1) {
			activateNext();
		}
	}
	if (!nextActive) {
		//document.getElementById("btnNext").style.backgroundPosition = "left top";
		$("#btnNext").removeClass("btnNext").addClass("btnNextDim").attr("title","Next (inactive)");
	}
	
	var img1alt = $("#img1").attr("alt");
	var img2alt = $("#img2").attr("alt");
	$("#img1").attr("title", img1alt);
	$("#img2").attr("title", img2alt);
	
	if (debug) {
        document.getElementById("debug").innerHTML = '<input type="text" maxlength="2" size="4" id="goPage" value="' + pageNum + '" /><input type="button" value="To Page" title="To Page" onMouseUp="jumpToPage2();" />';
    }
	
	try {
		enterPageLocal();
	}
	catch (err) {
	}
	//document.getElementById("debug").innerHTML = pageName;
	
	//Menu button handlers


$(function () {
    $("#hlp").click(function () { //help button
        popWin = window.open('Help.htm', 'Help_window', 'height=600,width=800,status=no,scrollbars=no,toolbar=no,menubar=no,location=no');
        popWin.focus();
		//startPopUp3("Help Button", "This button will display the Help Screen.");
        return false;
    });
    $("#idx").click(function () { //index button
		pageViewedList = parent.pagesViewed;
		pageNameArray = parent.pagesArray;
		popWin = window.open('IndexPage.htm', 'Index_window', 'height=600,width=800,status=no,scrollbars=yes,toolbar=no,menubar=no,location=no');
        popWin.focus();
		//startPopUp3("Index Button", "This button will provide an index of screens in this lesson.");
        return false;
    });
    $("#gls").click(function () { //glossary button
	    $("#top").focus();
		popWin = window.open('Glossary.htm', 'Glossary_window', 'height=600,width=800,status=no,scrollbars=yes,toolbar=no,menubar=no,location=no');
        popWin.focus();
		
		
		//startPopUp3("Glossary Button", "This button will display a Glossary .");
        return false;
    });
});
}
function doLoadNavVars() {
	if (pageNext == "" && pageIndex < pages.length)
		pageNext = pages[pageIndex + 1] + ".htm";
	if (pageBack == "" && pageIndex > 0)
		pageBack = pages[pageIndex - 1] + ".htm";
}




function goHome() {
	document.location.href = "Screen01.htm";
}
function goMenu() {
	parent.lastLessonPage = document.location.href;
	document.location.href = "IndexPage.htm";
}
function goHelp() {
	$("#btnHelp").blur();
	parent.lastLessonPage = document.location.href;
	document.location.href = "Help.htm";
}
function goResources() {
	parent.lastLessonPage = document.location.href;
	document.location.href = "Resources.htm";
}
function goGlossary() {
	parent.lastLessonPage = document.location.href;
	document.location.href = "Glossary.htm";
}
function goExit() {
	if (confirm("Exit the course?")) {
		//window.close();
		if (isSCORM)
			parent.QuitSCO();
		window.opener = self;
		window.top.close();
	}
}
function goBack() {
	if (backActive) {
		if (fbWin && fbWin.open && !fbWin.closed) {
			fbWin.close();
			fbWin = null;
		}
		if (pageBack == "" || pageBack == "undefined.htm")
			history.go(-1);
		else {
			if (pageBack.indexOf(".htm") == -1)
				pageBack += ".htm";
			document.location.href = pageBack;
		}
	} else {
		alert("The back button is currently inactive.  Please read the screen for instructions.");
	}
}
function goNext() {
	if (nextActive) {
		if (fbWin && fbWin.open && !fbWin.closed) {
			fbWin.close();
			fbWin = null;
		}
		if (pageNext == "") doLoadNavVars();
		if (pageNext == "*MENU*")
			goMenu();
		else {
			if (pageNext.indexOf(".htm") == -1)
				pageNext += ".htm";
			document.location.href = pageNext;
		}
	} else {
		alert("The next button is currently inactive.  Please read the screen for instructions.");
	}
}
function activateNext() {
	/*if (window.opener != null) {
		if (opener.pageTrack.indexOf("|" + pageName + "|") == -1) {
			opener.pageTrack += pageName + "|";
			opener.pageTrackChanged = true;
		}
	}*/
	addToPagesViewed(pageName);
	nextActive = true;
	//document.getElementById("btnNext").style.backgroundPosition = "left bottom";
	$("#btnNext").addClass("btnNext").removeClass("btnNextDim").attr("title","Next");
	setPrompt("*NEXT*");
}
function setPrompt(txt) {
	if (txt == "*NEXT*") txt = "Select Next to continue.";
	document.getElementById("prompt").innerHTML = txt;
}

// ------------- MISC -------------

function getCheckedValue(radioObj) {
	if (!radioObj)
		return "";
	var radioLength = radioObj.length;
	if (radioLength == undefined)
		if (radioObj.checked)
			return radioObj.value;
		else
			return "";
	for (var i = 0; i < radioLength; i++) {
		if (radioObj[i].checked) {
			return radioObj[i].value;
		}
	}
	return "";
}
function setCheckedValue(radioObj, data) {
	if (!radioObj)
		return;
	var radioLength = radioObj.length;
	if (radioLength == undefined)
		if (radioObj.value)
			radioObj.checked;
		else
			return;
	for (var i = 0; i < radioLength; i++) {
		if (radioObj[i].value == data) {
			radioObj[i].checked = true;
		}
	}
}


// ------------- ROLLOVER BUTTONS -------------

function MM_preloadImages() { //v3.0
	var d = document; if (d.images) {
		if (!d.MM_p) d.MM_p = new Array();
		var i, j = d.MM_p.length, a = MM_preloadImages.arguments; for (i = 0; i < a.length; i++)
			if (a[i].indexOf("#") != 0) { d.MM_p[j] = new Image; d.MM_p[j++].src = a[i]; }
	}
}

function MM_swapImgRestore() { //v3.0
	var i, x, a = document.MM_sr;
	for (i = 0; a && i < a.length && (x = a[i]) && x.oSrc; i++) {
		if (x.alt) {
			if (x.alt.indexOf("(inactive)") < 0) {
				//alert("src=" + x.src + "\n oSrc=" + x.oSrc);
				//x.src=x.oSrc;
				if (x.oSrc.indexOf("_ov_ck.") > 0) {
					x.src = x.oSrc.split("_ov_ck.").join("_ck.");
				} else {
					x.src = x.oSrc;
				}
			}
		} else {
			//if ((x.oSrc.indexOf("_ov_ck.") > 0) && (x.src == x.oSrc)) {
			if (x.oSrc.indexOf("_ov_ck.") > 0) {
				x.src = x.oSrc.split("_ov_ck.").join("_ck.");
			} else {
				x.src = x.oSrc;
			}
		}
	}
}

function MM_findObj(n, d) { //v3.0
	var p, i, x; if (!d) d = document; if ((p = n.indexOf("?")) > 0 && scormLoc.frames.length) {
		d = scormLoc.frames[n.substring(p + 1)].document; n = n.substring(0, p);
	}
	if (!(x = d[n]) && d.all) x = d.all[n]; for (i = 0; !x && i < d.forms.length; i++) x = d.forms[i][n];
	for (i = 0; !x && d.layers && i < d.layers.length; i++) x = MM_findObj(n, d.layers[i].document); return x;
}

function MM_swapImage() { //v3.0
	var i, j = 0, x, a = MM_swapImage.arguments;
	if (a[0] == "next" && !nextActive) return;
	if (a[0] == "back" && !backActive) return;
	if (a[0] == "cc" && !ccActive) return;
	if (a[0] == "audio" && !audioActive) return;
	if (document.getElementById(a[0]).alt.indexOf("(inactive)") >= 0) return;

	document.MM_sr = new Array; for (i = 0; i < (a.length - 2) ; i += 3)
		if ((x = MM_findObj(a[i])) != null) {
			document.MM_sr[j++] = x;

			if (!x.oSrc) x.oSrc = x.src;
			if ((x.src.indexOf("_ck.") > 0) && (a[i + 2].indexOf("_ov.") > 0)) {
				//handle over state for graphics that have a checkmark
				x.src = a[i + 2].split("_ov.").join("_ov_ck.");
			} else {
				x.src = a[i + 2];
			}
		}
}


// ------------- FEEDBACK -------------

var timerID = 0;
var feedback = "";
var fbWin = null;
var w, h, l, t = 0;
var header = "";
var text = "";
var popUpImageFile = "";
var popUpImageAlt = "";
var s = "yes";

function popUp(hdr, txt) {
	// Optional Arguments
	w = (arguments[2]) ? arguments[2] : 500;
	h = (arguments[3]) ? arguments[3] : 350;
	header = hdr;
	text = txt;
	if (fbWin && fbWin.open && !fbWin.closed) {
		fbWin.close();
		fbWin = null;
		timerID = setTimeout("displayPopUp()", 150)
	} else {
		displayPopUp();
	}
}

function displayPopUp() {
	clearTimeout(timerID);
	timerID = 0;
	var temp = "";

	l = (screen.width - w) / 2;
	t = (screen.height - h) / 2 - 30;

	fbWin = window.open("", "Popup", "width=" + w + ",height=" + h + ",left=" + l + ",top=" + t + ",toolbar=no,location=no,directories=no,status=no,menubar=no,scrollbars=" + s + ",resizable=yes");

	if (fbWin != null) {
		if (fbWin.opener == null)
			fbWin.opener = window;

		fbWin.document.write("<!DOCTYPE html>\n");
		fbWin.document.write("<html lang=\"en\">\n");
		fbWin.document.write("<head><title>Feedback &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;  &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<\/title>\n");
		//fbWin.document.write("<SCRIPT TYPE='text/javascript' SRC='buttons.js'><\/SCRIPT>\n");
		fbWin.document.write("<link href=\"css/styles.css\" rel=\"stylesheet\" type=\"text/css\" />\n");
		fbWin.document.write("<style type=\"text/css\">td {vertical-align:top; padding:0; background-repeat:no-repeat;}<\/style>\n");
		fbWin.document.write("</head><body style='margin:0; height:" + h + "px; background-color:#DEE7F7'>\n");
		fbWin.document.write("<table cellspacing='0' cellpadding='0' border='0' style='width:100%; height:100%; padding:0'>\n");
		fbWin.document.write("<tr>\n");
		fbWin.document.write("<td style='width:20px; height:20px; background-image:url(images/interface/pop-up_01.jpg)'><\/td>\n");
		fbWin.document.write("<td style='height:20px; background-image:url(images/interface/pop-up_02.jpg); background-repeat:repeat-x;'><\/td>\n");
		fbWin.document.write("<td style='width:20px; height:20px; background-image:url(images/interface/pop-up_03.jpg)'><\/td>\n");
		fbWin.document.write("<\/tr>\n");
		fbWin.document.write("<tr>\n");
		fbWin.document.write("<td style='width:20px; background-image:url(images/interface/pop-up_04.jpg); background-repeat:repeat-y;'><\/td>\n");
		fbWin.document.write("<td style='height:" + (h-40) + "px; background-image:url(images/interface/pop-up_05.jpg); background-repeat:repeat;'>\n");
		fbWin.document.write("<div class=\"textHeader\">" + header + "<\/div>\n");
		if (popUpImageFile != "") {
			fbWin.document.write("<img src='images/interface/" + popUpImageFile + "' ALIGN='RIGHT' HSPACE='20' alt=\"" + popUpImageAlt + "\" BORDER='0' />\n");
		}
		fbWin.document.write("<div style='max-height:" + (h - 129) + "px; overflow:auto'>" + text + "<\/div>\n");
		temp = text.substring(text.length - 10);
		temp = temp.toUpperCase();
		if (temp.indexOf("</UL>") < 0 && temp.indexOf("</TABLE>") < 0) fbWin.document.write("<br />");
		//fbWin.document.write("\n<BR>");
		fbWin.document.write("\n<div align='center'><a class='btnPopupClose' href='javascript:window.close();' title='Close'><\/a><\/div>\n");
		//fbWin.document.write("\n<div ALIGN='CENTER'><a class='btnPopupClose' HREF='JavaScript:window.close();'><img NAME='close' SRC='images/interface/btn_Close.jpg' WIDTH='66' HEIGHT='30' alt='Close' title='Close' BORDER='0' /></a></div>\n");
		//fbWin.document.write("<DIV ALIGN='CENTER'><A HREF='JavaScript:window.close();' ONMOUSEOVER=\"MM_swapImage('close','','images/interface/btn_Close_ov.jpg',1)\" ONMOUSEOUT='MM_swapImgRestore()'><IMG NAME='close' SRC='images/interface/btn_Close.jpg' WIDTH='66' HEIGHT='30' ALT='Close' BORDER='0'></A></DIV>\n");
		fbWin.document.write("<\/td>\n");
		fbWin.document.write("<td style='width:20px; background-image:url(images/interface/pop-up_06.jpg); background-repeat:repeat-y;'><\/td>\n");
		fbWin.document.write("<\/tr>\n");
		fbWin.document.write("<tr>\n");
		fbWin.document.write("<td style='width:20px; height:20px; background-image:url(images/interface/pop-up_07.jpg)'><\/td>\n");
		fbWin.document.write("<td style='height:20px; background-image:url(images/interface/pop-up_08.jpg); background-repeat:repeat-x;'><\/td>\n");
		fbWin.document.write("<td style='width:20px; height:20px; background-image:url(images/interface/pop-up_09.jpg)'><\/td>\n");
		fbWin.document.write("<\/tr>\n");
		fbWin.document.write("<\/table>\n");
		fbWin.document.write("<\/body><\/html>");
		//fbWin.document.close();
		fbWin.focus();
	}
}



var PANEL_NORMAL_CLASS = "glossary";
var PANEL_COLLAPSED_CLASS = "glossaryCollapsed";
var PANEL_HEADING_TAG = "h2";
var PANEL_CONTENT_CLASS = "glossaryDefinition";
var PANEL_COOKIE_NAME = "glossary";
var PANEL_ANIMATION_DELAY = 20; /*ms*/
var PANEL_ANIMATION_STEPS = 10;

function setUpPanels() {
	loadSettings();

	// get all headings
	var headingTags = document.getElementsByTagName(PANEL_HEADING_TAG);

	// go through all tags
	for (var i = 0; i < headingTags.length; i++) {
		var el = headingTags[i];

		// make sure it's the heading inside a panel
		if (el.parentNode.className != PANEL_NORMAL_CLASS && el.parentNode.className != PANEL_COLLAPSED_CLASS)
			continue;

		// get the text value of the tag
		var name = el.firstChild.nodeValue;

		// look for the name in loaded settings, apply the normal/collapsed class
		if (panelsStatus[name] == "false")
			el.parentNode.className = PANEL_COLLAPSED_CLASS;
		else
			if (panelsStatus[name] == "true")
				el.parentNode.className = PANEL_NORMAL_CLASS;
			else {
				// if no saved setting, see the initial setting
				panelsStatus[name] = (el.parentNode.className == PANEL_NORMAL_CLASS) ? "true" : "false";
			}

		// add the click behavor to headings
		el.onclick = function () {
			var target = this.parentNode;
			var name = this.firstChild.nodeValue;
			var collapsed = (target.className == PANEL_COLLAPSED_CLASS);
			saveSettings(name, collapsed ? "true" : "false");
			animateTogglePanel(target, collapsed);
		};
	}
}

/**
 * Start the expand/collapse animation of the panel
 * @param panel reference to the panel div
 */
function animateTogglePanel(panel, expanding) {
	// find the .panelcontent div
	var elements = panel.getElementsByTagName("div");
	var panelContent = null;
	for (var i = 0; i < elements.length; i++) {
		if (elements[i].className == PANEL_CONTENT_CLASS) {
			panelContent = elements[i];
			break;
		}
	}

	// make sure the content is visible before getting its height
	panelContent.style.display = "block";

	// get the height of the content
	var contentHeight = panelContent.offsetHeight;

	// if panel is collapsed and expanding, we must start with 0 height
	if (expanding)
		panelContent.style.height = "0px";

	var stepHeight = contentHeight / PANEL_ANIMATION_STEPS;
	var direction = (!expanding ? -1 : 1);

	setTimeout(function () { animateStep(panelContent, 1, stepHeight, direction) }, PANEL_ANIMATION_DELAY);
}

/**
 * Change the height of the target
 * @param panelContent	reference to the panel content to change height
 * @param iteration		current iteration; animation will be stopped when iteration reaches PANEL_ANIMATION_STEPS
 * @param stepHeight	height increment to be added/substracted in one step
 * @param direction		1 for expanding, -1 for collapsing
 */
function animateStep(panelContent, iteration, stepHeight, direction) {
	if (iteration < PANEL_ANIMATION_STEPS) {
		panelContent.style.height = Math.round(((direction > 0) ? iteration : 10 - iteration) * stepHeight) + "px";
		iteration++;
		setTimeout(function () { animateStep(panelContent, iteration, stepHeight, direction) }, PANEL_ANIMATION_DELAY);
	} else {
		// set class for the panel
		panelContent.parentNode.className = (direction < 0) ? PANEL_COLLAPSED_CLASS : PANEL_NORMAL_CLASS;
		// clear inline styles
		panelContent.style.display = panelContent.style.height = "";
	}
}

// -----------------------------------------------------------------------------------------------
// Load-Save
// -----------------------------------------------------------------------------------------------
/**
 * Reads the "panels" cookie if exists, expects data formatted as key:value|key:value... puts in panelsStatus object
 */
function loadSettings() {
	// prepare the object that will keep the panel statuses
	panelsStatus = {};

	// find the cookie name
	var start = document.cookie.indexOf(PANEL_COOKIE_NAME + "=");
	if (start == -1) return;

	// starting point of the value
	start += PANEL_COOKIE_NAME.length + 1;

	// find end point of the value
	var end = document.cookie.indexOf(";", start);
	if (end == -1) end = document.cookie.length;

	// get the value, split into key:value pairs
	var cookieValue = unescape(document.cookie.substring(start, end));
	var panelsData = cookieValue.split("|");

	// split each key:value pair and put in object
	for (var i = 0; i < panelsData.length; i++) {
		var pair = panelsData[i].split(":");
		panelsStatus[pair[0]] = pair[1];
	}
}

function expandAll() {
	for (var key in panelsStatus)
		saveSettings(key, "true");

	setUpPanels();
}

function collapseAll() {
	for (var key in panelsStatus)
		saveSettings(key, "false");

	setUpPanels();
}

/**
 * Takes data from the panelsStatus object, formats as key:value|key:value... and puts in cookie valid for 365 days
 * @param key	key name to save
 * @paeam value	key value
 */
function saveSettings(key, value) {
	// put the new value in the object
	panelsStatus[key] = value;

	// create an array that will keep the key:value pairs
	var panelsData = [];
	for (var key in panelsStatus)
		panelsData.push(key + ":" + panelsStatus[key]);

	// set the cookie expiration date 1 year from now
	var today = new Date();
	var expirationDate = new Date(today.getTime() + 365 * 1000 * 60 * 60 * 24);
	// write the cookie
	document.cookie = PANEL_COOKIE_NAME + "=" + escape(panelsData.join("|")) + ";expires=" + expirationDate.toGMTString();
}

// -----------------------------------------------------------------------------------------------
// Register setUpPanels to be executed on load
if (window.addEventListener) {
	// the "proper" way
	window.addEventListener("load", setUpPanels, false);
}
else
	if (window.attachEvent) {
		// the IE way
		window.attachEvent("onload", setUpPanels);
	}

// ------------- SCORM -------------
var isSCORM = false;
if (typeof parent.SetCompleteFromChild == "function") isSCORM = true;
if (isSCORM) {
	var s1 = "";
	s1 += window.location;
	parent.SetBookmark(s1);
}
function setComplete() {
	if (isSCORM) parent.SetCompleteFromChild();
}

// Add current page to PagesViewed 
function addToPagesViewed(p) {
	if (isSCORM) {
		if (parent.pagesViewed.indexOf("|" + p + "|") == -1) parent.pagesViewed += p + "|";
	}
}
function checkPagesViewed(p) {
	if (isSCORM) {
		if (parent.pagesViewed.indexOf("|" + p + "|") != -1)
			return true;
		else
			return false;
	}
}
function jumpToPage2() {
	var pNum = $("#goPage").attr("value");
	//if (pNum.toString().length == 1)
	//	pNum = "0" + pNum;
	//var pNum = document.getElementById("goPage").value;
	//pNum = "Screen" + pNum;
	//document.location.href = pNum + ".htm";
	document.location.href = pages[pNum] + ".htm";
}