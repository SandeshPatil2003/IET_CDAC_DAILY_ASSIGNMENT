/**
 * 
 */

 function display(){
	 
	 
	 
	 /*
	 document.getElementsByTagName("p")[0].innerHTML = "Hello from me ";
	 document.getElementById("hw").innerHTML = "CLICKED ";
*/


const mainPara = document.getElementsByTagName("p")[0];
    const mainTitle = document.getElementById("hw");

    // Define original and new text states
    const originalParaText = "This is para";
    const newParaText = "Hello from me ";
    const originalTitleText = "HELLO This is my first webappProject";
    const newTitleText = "CLICKED ";

    // Toggle the paragraph text
    // We use .textContent here as a robust way to check and set plain text
    if (mainPara.textContent.trim() === originalParaText.trim()) {
        mainPara.textContent = newParaText;
    } else {
        mainPara.textContent = originalParaText;
    }

    // Toggle the H1 text
    if (mainTitle.textContent.trim() === originalTitleText.trim()) {
        mainTitle.textContent = newTitleText;
    } else {
        mainTitle.textContent = originalTitleText;
    }

 }