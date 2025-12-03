let fs= require('fs').promises



//const { readFile } = require('node:fs/promises');
//const { resolve } = require('node:path');
async function logFile() {
  try {
    //const filePath = resolve('./package.json');
    const contents = await fs.readFile("data.txt", { encoding: 'utf8' });
    console.log(contents);
  } catch (err) {
    console.error(err.message);
  }
}
logFile();