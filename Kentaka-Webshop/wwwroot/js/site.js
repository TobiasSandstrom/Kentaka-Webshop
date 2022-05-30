// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


/* --------- Rasmus Navbar Search ---------*/

// getting all required elements
const suggBox = document.querySelector(".autocom-box");
const inputBox = document.querySelector("#searchfunction");

//if user press any key and release
inputBox.onkeyup = (e) => {
    let userData = e.target.value; // User enter data
    let emptyArray = [];
    if (userData) {
        emptyArray = suggestions.filter((data) => {
            //filtering array value and user chat to lowercase
            // and return only those word/sentences which starts with user entered word
            return data.toLocaleLowerCase().startsWith(userData.toLocaleLowerCase());
        });
        emptyArray = emptyArray.map((data) => {
            return data = '<li>' + data + '</li>';
        });
        console.log(emptyArray);
        suggBox.classList.add("active"); // shows autocomplete box
        showSuggestions(emptyArray);
        let allList = suggBox.querySelectorAll("li");
        for (let i = 0; i < allList.length; i++) {
            allList[i].setAttribute("onclick", "select(this)");
        }
    } else {
        suggBox.classList.remove("active"); // hides autocomplete box
    }
}

function select(element) {
    let selectUserData = element.textContent;
    inputBox.value = selectUserData; // passing the user selected value in searchbar
    suggBox.classList.remove("active"); // hides autocomplete box
}

function showSuggestions(list) {
    let listData;
    if (!list.length) {
        userValue = inputBox.value;
        listData = '<li>' + userValue + '</li>';
    } else {
        listData = list.join('');
    }
    suggBox.innerHTML = listData;
}
