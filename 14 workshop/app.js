let shipyard = []
$('#createFighter').click(function (){
    let Ship = {
        name: $("#name").val(), 
        pilot: $("#pilot").val(), 
        // pilot: 'DarthVader', 
        fuelTankCapacity: $('#fuel').val(), 
        currentLocation: $('#curentLoc').val(), 
        type: $(".typevalue").val(), 
        weapons: $('#weapons').val(), 
        shield: $('#shield').val(), 
        cargoCapacity: $('#cargoCapacity').val(),
        tradingRoute: $('#tradingRoute').val(),
        loadingCranes: $('#loadingCranes').val(),
        miningTools: $("#miningTools").val(),
        miningTypes: $('#miningTypes').val(),

    }
    
    shipyard.unshift(new Fighter(Ship))
    renderShipCard(shipyard[0])

})

$('#createCargo').click(function (){
    let Ship = {
        name: $("#name-cargo").val(), 
        pilot: $("#pilot-cargo").val(), 
        // pilot: 'DarthVader', 
        fuelTankCapacity: $('#fuel-cargo').val(), 
        currentLocation: $('#curentLoc-cargo').val(), 
        type: $("select").val('cargo'), 
        weapons: $('#weapons-cargo').val(), 
        shield: $('#shield-cargo').val(), 
        cargoCapacity: $('#cargoCapacity-cargo').val(),
        tradingRoute: $('#tradingRoute-cargo').val(),
        loadingCranes: $('#loadingCranes-cargo').val(),
        miningTools: $("#miningTools-cargo").val(),
        miningTypes: $('#miningTypes-cargo').val(),
        
    }
    
    shipyard.unshift(new Cargo(Ship))
    renderShipCard(shipyard[0])
    console.log(shipyard[0])

})

$('#createMiner').click(function (){
    let Ship = {
        name: $("#name-miner").val(), 
        pilot: $("#pilot-miner").val(), 
        // pilot: 'DarthVader', 
        fuelTankCapacity: $('#fuel-miner').val(), 
        currentLocation: $('#curentLoc-miner').val(), 
        type: $(".typevalue-miner").val('miner'), 
        weapons: $('#weapons-miner').val(), 
        shield: $('#shield-miner').val(), 
        cargoCapacity: $('#cargoCapacity-miner').val(),
        tradingRoute: $('#tradingRoute-miner').val(),
        loadingCranes: $('#loadingCranes-miner').val(),
        miningTools: $("#miningTools-miner").val(),
        miningTypes: $('#miningTypes-miner').val(),
        miningStorage:$('#miningStorage-miner').val()
    }
    
    shipyard.unshift(new Mining(Ship))
    renderShipCard(shipyard[0])

})




// shipyard.push(new Fighter(figherShip))
// shipyard.push(new Fighter(figherShip))


const getProperties = ship => {
    str = ''
    for (const key in ship) {
        if(key !== 'name' || key !== 'type') {
            str += `<p class="card-text"><strong>${key}</strong> ${ship[key]}</p>`
        }        
    }
    return str
}

const renderShipCard = ship => {
    $('.station').append(`
    <div class="col">
        <div class="card" style="width: 18rem;">
            <div class="card-body">
                <h5 class="card-title">${ship.name}</h5>
                <h6 class="card-subtitle mb-2 text-muted">${ship.type}</h6>
                ${getProperties(ship)}
            </div>
        </div>
        <button type="button" id='start' class="btn btn-secondary">Start engine</button>
        <button type="button" id='takeOff' class="btn btn-secondary">take off</button>
        <button type="button" id='land' class="btn btn-secondary">Land</button>
    </div>
    `)
    $(document.getElementsByClassName('station')[0]).on('click', $('#start'), ()=>{
        alert(shipyard[0].startEngine())
    })
}


// for (const ship of shipyard) {
//     renderShipCard(ship)
// }

