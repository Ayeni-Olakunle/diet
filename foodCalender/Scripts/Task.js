let food = [
    {
        id: 1,
        foodTodate: "Bread and Beans",
        condition: "morning"
    },
    {
        id: 2,
        foodTodate: "Rice and Beans",
        condition: "morning"
    },
    {
        id: 3,
        foodTodate: "Garri and Beans",
        condition: "morning"
    },
    {
        id: 4,
        foodTodate: "Yam and Beans",
        condition: "morning"
    },
    {
        id: 5,
        foodTodate: "Plantain and Beans",
        condition: "morning"
    }

]
let content = document.getElementById("content")
let count = 0;
function check(e) {
    console.log(food[count].foodTodate)
    content.innerHTML = `<p class="morning">${food[count].foodTodate}</p>`
    count += 1;
}

function pre(e) {
    console.log(food[count].foodTodate)
    content.innerHTML = `<p class="morning">${food[count].foodTodate}</p>`
    count -= 1;
}