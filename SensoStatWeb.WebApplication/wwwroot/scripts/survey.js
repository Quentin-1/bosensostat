function slist () {
    var target = document.getElementById("sortlist");
    target.classList.add("slist");
    let items = target.getElementsByTagName("li"), current = null;
  
    var index = 0;
    // (B) MAKE ITEMS DRAGGABLE + SORTABLE
    for (let i of items) {
      // (B1) ATTACH DRAGGABLE
      index++;
      i.draggable = true;
      
      // (B2) DRAG START - YELLOW HIGHLIGHT DROPZONES
      i.ondragstart = (ev) => { current = i; };
      
      
      // When we passed with item in mouse on other item
      i.ondragenter = (ev) => {
        if (i != current) { i.classList.add("active"); }
      };
  
      // When we passed with item in mouse on other item
      i.ondragleave = () => {
        i.classList.remove("active");
      };
  
      // (B5) DRAG END - REMOVE ALL HIGHLIGHTS
      i.ondragend = () => { for (let it of items) {
          it.classList.remove("active");

      }};
   
      // (B6) DRAG OVER - PREVENT THE DEFAULT "DROP", SO WE CAN DO OUR OWN
      i.ondragover = (evt) => { evt.preventDefault(); };
   
      // (B7) ON DROP - DO SOMETHING
      i.ondrop = (evt) => {
        evt.preventDefault();
        if (i != current) {
          let currentpos = 0, droppedpos = 0;
          for (let it=0; it<items.length; it++) {
            if (current == items[it]) { currentpos = it; }
            if (i == items[it]) { droppedpos = it; }
          }
          if (currentpos < droppedpos) {
            i.parentNode.insertBefore(current, i.nextSibling);
          } else {
            i.parentNode.insertBefore(current, i);
          }
          orderInputs();
        }
      };
    }
    orderInputs();
  }

function orderInputs(){

    var orderInput = document.getElementById("orderInputs");

    var list = document.getElementById("sortlist");
    orderInput.value = "";

    list.querySelectorAll('input').forEach(currentInput => {
        orderInput.value += currentInput.placeholder.replace("Ajouter une", "");
    });
}
  
      function addInput(name) {
          event.preventDefault();
  
          var ul = document.getElementById('sortlist'); // get the list
  
          var li = document.createElement('li'); // Create parent div
          var input = document.createElement('input'); // Create input
          var i = document.createElement('i'); // create i 
          var p = document.createElement('p');
  
          li.classList.add("roundedOrangeInput"); // Add class to parent div
          li.classList.add("bigInput"); // Add class to parent div
  
          li.setAttribute("draggable", "true");
  
          input.placeholder = "Ajouter une " + name; // Add placeholder in input
          input.name = "inputQuestionInstruction";
          
          p.textContent = name + " : ";
          p.style.marginTop = "auto";
          p.style.marginBottom = "auto";

  
          i.onclick = deleteInput; // When click on i call deleteInput
          i.classList.add("fas"); // Add trash style to i
          i.classList.add("fa-trash-alt"); // Add trash style to i
  
          li.appendChild(p);
          li.appendChild(input); // Add input to div
          li.appendChild(i);  // Add i to div
  
  
          ul.appendChild(li); // Add div and child to list

          slist();
      }
  
      function deleteInput(caller){
        if(caller.srcElement == undefined){
          caller.parentNode.remove();
        }
        else{
          caller.srcElement.parentNode.remove(); // find the parent div and remove it
        }
          orderInputs();
      }