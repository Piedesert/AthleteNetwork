// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const uri = 'https://api.nationalize.io';
let people = [];


function getPeoplpe() {
    fetch(uri)
        .then(response => response.json())
        .then(data => _displayPeople(data))
        .catch(error => console.error('Unable to get people.', error));
}

function _displayCount(personCount) {
    const name = (personCount === 1) ? 'person' : 'people';

    document.getElementById('counter').innerText = `${personCount} ${name}`;
}

function _displayPeople(data) {
    const tBody = document.getElementById('people');
    tBody.innerHTML = '';

    _displayCount(data.length);

    data.forEach(person => {
        let tr = tBody.insertRow();

        let td1 = tr.insertCell(0);
        let textNode = document.createTextNode(person.name);
        td1.appendChild(isCompleteCheckbox);

        let td2 = tr.insertCell(1);
        let textNode = document.createTextNode(person.country);
        td2.appendChild(textNode);

        let td3 = tr.insertCell(2);
        td3.appendChild(editButton);

        let td4 = tr.insertCell(3);
        td4.appendChild(deleteButton);
    });

    people = data;
}