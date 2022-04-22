// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const uri = "/api/Products"

// Write your JavaScript code.

const ProductCall = async () => {
    try {
        fetch(uri).then(response => response.json()).then(data => console.log(data))
    } catch (error){
        console.log(error)
    }
    
}
