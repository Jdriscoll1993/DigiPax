// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var formInput = document.getElementsByClassName("form-row");

document.getElementById("add-sample").addEventListener("click", function () {
    var elements = document.querySelectorAll(".sample-item");
    var count = elements.length;

    var newSampleLabel = document.createElement("label");

    var newSampleInput = document.querySelector("#name-select").cloneNode(true);

    newSampleLabel.setAttribute("class", "control-label");
    newSampleLabel.setAttribute("id", "name-label");
    newSampleLabel.setAttribute("for", "Sample" + count);


    newSampleInput.setAttribute("class", "form-control");
    newSampleInput.setAttribute("id", "name-select");

    newSampleInput.setAttribute("name", "SampleIds[" + count + "]");

    newSampleInput.setAttribute("type", "text");

    var formContainer = document.querySelector(".form-row");
    var formGroupDiv = document.createElement("div");
    formGroupDiv.setAttribute("class", "form-group sample-item");

    var rowDiv = document.createElement("div");
    rowDiv.setAttribute("class", "row");

    var sampleDiv = document.createElement("div");
    sampleDiv.setAttribute("class", "col-xl-12");

    sampleDiv.append(newSampleLabel);
    sampleDiv.append(newSampleInput);

    formGroupDiv.append(rowDiv);
    rowDiv.append(sampleDiv);

    formContainer.append(formGroupDiv);


    ////opt is type NodeList
    //var opt = document.querySelectorAll("option");
    //var select = document.querySelector("#name-select");
    ////foreach over options => o append select


});