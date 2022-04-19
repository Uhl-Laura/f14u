export async function getChanges()
{
    const response = await fetch('https://localhost:5001/credentials');
    const jsonResponse = await response.json();
    return jsonResponse
}