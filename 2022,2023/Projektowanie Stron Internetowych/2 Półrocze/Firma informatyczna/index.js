const content = document.querySelector(".content")
const item1 = document.querySelector(".item1")
const item2 = document.querySelector(".item2")
const item3 = document.querySelector(".item3")
const item4 = document.querySelector(".item4")
const item5 = document.querySelector(".item5")

let html = `<div class="content-header">Firma Informatyczna</div>
<div class="content-nav">
    <div class="item">Lorem ipsum dolor sit</div>
    <div class="item r">Lorem ipsum dolor sit</div>
</div>
<div class="serwis-container">
    <img class="serwis" src="img/serwis.png" alt="">
</div>
<p> Lorem ipsum dolor sit amet consectetur adipisicing elit.
    Nulla, labore? Atque ullam, deserunt tempora, voluptatum iste at nostrum qui autem voluptates exercitationem repudiandae? 
    Soluta minus ullam nostrum maiores odio nam? Lorem ipsum dolor sit amet consectetur, adipisicing elit. 
    Fuga enim distinctio error in quibusdam molestiae unde repellendus ea itaque iste dolorem placeat eos debitis nostrum, possimus,
    nemo corrupti nobis inventore. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ipsum dicta hic, necessitatibus quae reprehenderit sapiente placeat at laborum tempore, labore doloremque in. Veritatis porro aut, dolorum voluptatibus quaerat repellat. Accusantium.
    Lorem ipsum dolor sit, amet consectetur adipisicing elit. Similique, enim! Assumenda sit tenetur eligendi natus voluptate ratione in odit, quis eos minima exercitationem repellat labore non aperiam voluptatibus deleniti ex?
    Lorem ipsum dolor sit amet consectetur adipisicing elit. Quia sint maxime aperiam enim corporis cupiditate eius debitis minus vitae repudiandae, soluta sequi. Odit alias tempore incidunt nulla, sit quam iste!
</p>
<div class="footer">
    <p>Kacper Prochwicz</p>
</div>`

function generWeb(html){
    content.innerHTML = html;
}

generWeb(html)

item1.addEventListener("click", () => {
    let html = `<div class="content-header">Firma Informatyczna</div>
    <div class="content-nav">
        <div class="item">Lorem ipsum dolor sit</div>
        <div class="item r">Lorem ipsum dolor sit</div>
    </div>
    <div class="serwis-container">
        <img class="serwis" src="img/serwis.png" alt="">
    </div>
    <p> Lorem ipsum dolor sit amet consectetur adipisicing elit.
        Nulla, labore? Atque ullam, deserunt tempora, voluptatum iste at nostrum qui autem voluptates exercitationem repudiandae? 
        Soluta minus ullam nostrum maiores odio nam? Lorem ipsum dolor sit amet consectetur, adipisicing elit. 
        Fuga enim distinctio error in quibusdam molestiae unde repellendus ea itaque iste dolorem placeat eos debitis nostrum, possimus,
        nemo corrupti nobis inventore. Lorem ipsum dolor sit, amet consectetur adipisicing elit. Ipsum dicta hic, necessitatibus quae reprehenderit sapiente placeat at laborum tempore, labore doloremque in. Veritatis porro aut, dolorum voluptatibus quaerat repellat. Accusantium.
        Lorem ipsum dolor sit, amet consectetur adipisicing elit. Similique, enim! Assumenda sit tenetur eligendi natus voluptate ratione in odit, quis eos minima exercitationem repellat labore non aperiam voluptatibus deleniti ex?
        Lorem ipsum dolor sit amet consectetur adipisicing elit. Quia sint maxime aperiam enim corporis cupiditate eius debitis minus vitae repudiandae, soluta sequi. Odit alias tempore incidunt nulla, sit quam iste!
    </p>
    <div class="footer">
        <p>Kacper Prochwicz</p>
    </div>`
    generWeb(html)
})

item2.addEventListener("click", () => {
    let html = `<div class="content-header">Firma Informatyczna</div>
    <div class="content-nav">
        <div class="item">Lorem ipsum dolor sit</div>
        <div class="item r">Lorem ipsum dolor sit</div>
    </div>
    <div class="serwis-container">
        <img class="serwis" src="img/serwis.png" alt="">
    </div>
    <p> TO JEST TEKST O FIRMIE
    </p>
    <div class="footer">
        <p>Kacper Prochwicz</p>
    </div>`
    generWeb(html)
})

item3.addEventListener("click", () => {
    let html = `<div class="content-header">Firma Informatyczna</div>
    <div class="content-nav">
        <div class="item">Lorem ipsum dolor sit</div>
        <div class="item r">Lorem ipsum dolor sit</div>
    </div>
    <div class="serwis-container">
        <img class="serwis" src="img/serwis.png" alt="">
    </div>
    <p> NASZE USŁUGI
    </p>
    <div class="footer">
        <p>Kacper Prochwicz</p>
    </div>`
    generWeb(html)
})

item4.addEventListener("click", () => {
    let html = `<div class="content-header">Firma Informatyczna</div>
    <div class="content-nav">
        <div class="item">Lorem ipsum dolor sit</div>
        <div class="item r">Lorem ipsum dolor sit</div>
    </div>
    <p>ul. Jasia
    32-006 Niepołomice
    tel. 123-456-789</p>
    <div style="text-decoration:none; overflow:hidden;max-width:100%;width:596px;height:450px;"><div id="canvas-for-googlemap" style="height:100%; width:100%;max-width:100%;"><iframe style="height:100%;width:100%;border:0;" frameborder="0" src="https://www.google.com/maps/embed/v1/place?q=Rynek+w+Niepołomicach,+Niepołomice,+Polska&key=AIzaSyBFw0Qbyq9zTFTd-tUY6dZWTgaQzuU17R8"></iframe></div><a class="my-codefor-googlemap" rel="nofollow" href="https://www.bootstrapskins.com/themes" id="enable-map-data">premium bootstrap themes</a><style>#canvas-for-googlemap .text-marker{}.map-generator{max-width: 100%; max-height: 100%; background: none;</style></div>
    <div class="footer">
        <p>Kacper Prochwicz</p>
    </div>`
    generWeb(html)
})

item5.addEventListener("click", () => {
    let html = `<div class="content-header">Firma Informatyczna</div>
    <div class="content-nav">
        <div class="item">Lorem ipsum dolor sit</div>
        <div class="item r">Lorem ipsum dolor sit</div>
    </div>
    <div class="serwis-container">
        <img class="serwis" src="img/serwis.png" alt="">
    </div>
    <p> KONTAKT
    </p>
    <div class="footer">
        <p>Kacper Prochwicz</p>
    </div>`
    generWeb(html)
})