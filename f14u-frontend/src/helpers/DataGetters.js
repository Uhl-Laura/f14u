export async function getData(endpoint, filter){
    const response = await fetch(endpoint + filter);
    const jsonResponse = await response.json();
    return jsonResponse
}

export async function postData(endpoint, data){
    var promise = fetch(endpoint, {
        method: "POST",
        body: JSON.stringify(data),
        headers:{
            'Access-Control-Allow-Origin':'*'
        }
    })
    return promise;
}

export async function deleteData(endpoint, filter){
    var promise = fetch(endpoint + filter, {
        method: "DELETE",
    });
    return promise;
}