var rootFolder = "";

function keyUpLocal(e) {
	//if (nextActive) return;
	if (document.getElementById('Q1a').disabled) return;
	if (window.event) {
		var keynum = e.keyCode;
	} else if (e.which) {
		var keynum = e.which;
	}
	var keychar = String.fromCharCode(keynum);
	if (keynum == 13) {
		judge();
		return;
	}
	var keychar = String.fromCharCode(keynum);
	if ((keynum >= 65) && (keynum <= 64+choices)) {
		document.getElementById('Q1' + keychar.toLowerCase()).checked = !document.getElementById('Q1' + keychar.toLowerCase()).checked;
		choiceSelected();
		return;
	} else if (keynum == 13) {
		judge();
		return;
	}
}

function enableSubmit(enable) {
	if (enable) {
		document.getElementById('submit').src = rootFolder + "images/interface/btn_Submit_up.png";
		document.getElementById('submit').alt = "Submit";
	} else {
		document.getElementById('submit').src = rootFolder + "images/interface/btn_Submit_dim.png";
		document.getElementById('submit').alt = "Submit (inactive)";
	}
}

function enterPageLocal() {
	enableSubmit(false);

	if (checkLinkDone(1)) {
		showAnswers();
		activateNext();
	}
}

function choiceSelected() {
	studentResponse = "";
	var ltr = "";
	for (var i=65; i<=64+choices; ++i) {
		ltr = String.fromCharCode(i).toLowerCase();
		if (document.getElementById('Q1' + ltr).checked) {
			studentResponse += ltr.toUpperCase();
		}
	}
	//if (studentResponse.length > 0) {
	if (studentResponse.length == correctResponse.length) {
		enableSubmit(true);
	} else {
		enableSubmit(false);
	}
}

function judge() {
	if (document.getElementById('submit').alt == "Submit (inactive)") {
		alert("The submit button is currently inactive.  Please read the screen for instructions.");
		return;
	}

	if (studentResponse == correctResponse) {
		showAnswers();
		//document.getElementById('qFeedback').innerHTML = FDBK_correct;
		popUp("Feedback", FDBK_correct);
		finishQuestion();
	} else
		if (FDBK_count==1) {
			showAnswers();
			//document.getElementById('qFeedback').innerHTML = FDBK_incorrect_2;
			popUp("Feedback", FDBK_incorrect_2);
			finishQuestion();
		} else {
			FDBK_count++;
			enableSubmit(false);
			//document.getElementById('qFeedback').innerHTML = FDBK_incorrect_1;
			popUp("Feedback", FDBK_incorrect_1);
		}
}

function showAnswers() {
	for (var i=0; i<correctResponse.length; ++i) {
		var row = correctResponse.charCodeAt(i) - 65;
		//document.getElementById('questionChoices').rows[row].cells[0].innerHTML = "&#x2713;";
		document.getElementById('questionChoices').rows[row].cells[0].innerHTML = "&#x2714;";
	}
}

function finishQuestion() {
	enableSubmit(false);
	for (var i=65; i<=64+choices; ++i) {
		var ltr = String.fromCharCode(i).toLowerCase();
		document.getElementById('Q1' + ltr).disabled = true;
	}
	activateNext();
	addToPagesViewed(pageName);
	//setLinkComplete(1);
}
