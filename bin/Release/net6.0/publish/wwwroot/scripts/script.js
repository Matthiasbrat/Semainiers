export function setActive(e) {

    var activeElement = (document.getElementsByClassName('list-group-item list-group-item-action flex-column align-items-start active'));
    var elements = (document.getElementsByClassName('list-group-item list-group-item-action flex-column align-items-start'));

    if (activeElement.length > 0)
    {
        (activeElement[0]).classList.remove('active');
    }
    elements[e].classList.add('active');
}

export function getSelectedOptionValue() {

    var activeElement = (document.getElementsByClassName('list-group-item list-group-item-action flex-column align-items-start active'));
    var elements = (document.getElementsByClassName('list-group-item list-group-item-action flex-column align-items-start'));

    if (activeElement.length > 0) {
        (activeElement[0]).classList.remove('active');
    }
    elements[e].classList.add('active');
}