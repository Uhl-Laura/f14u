import { Constants } from "@/constants";
export async function getChanges()
{
    const response = await fetch(Constants.CREDENTIALS_URL);
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