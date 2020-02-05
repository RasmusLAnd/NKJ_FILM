
let dropdown = document.querySelector('.locality-dropdown');
dropdown.length = 0;

let defaultOption = document.createElement('option');
defaultOption.text = 'Choose Film';

dropdown.add(defaultOption);
dropdown.selectedIndex = 0;

const url = 'https://localhost:44310/api/films';

fetch(url)
    .then(
        function (response) {
            if (response.status !== 200) {
                console.warn('Looks like there was a problem. Status Code: ' +
                    response.status);
                return;
            }

            // Examine the text in the response  
            response.json().then(function (data) {
                let option;

                for (let i = 0; i < data.length; i++) {
                    option = document.createElement('option');
                    option.text = data[i].name;
                    option.value = data[i].filmId;
                    dropdown.add(option);
                }
            });
        }
    )
    .catch(function (err) {
        console.error('Fetch Error -', err);
    });

function getOption() {
    selectElement =
        document.querySelector('.locality-dropdown');

    output = selectElement.value;
    console.log(output);
    localStorage.setItem("id", output);
}