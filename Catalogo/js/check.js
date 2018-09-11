var checks = document.getElementsByClassName("checkModific");

for (var x=0; x < checks.length; x++) {
	var id = checks[x].id;
	if (checks[x].id == ""){
		checks[x].id = "chk" + x;
		id = "chk" + x;
	}
	var divParent = document.createElement("div");
	divParent.id = "div" + id;
	
	checks[x].parentNode = divParent;
	var parent = checks[x].parentNode;
	var label = document.createElement("label");
	label.htmlFor = id;
	parent.appendChild(label);
	       
}
