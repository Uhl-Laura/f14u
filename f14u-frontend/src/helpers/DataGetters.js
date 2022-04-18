export async function getChanges()
{
    const response = await fetch('http://localhost:5000/credentials');
    const jsonResponse = await response.json();
    return jsonResponse
}