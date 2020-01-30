## TypeScript:
- install node.js
- in CMD/Powershell/bash run `npm install -g typescript`
- create folder for TS project
- create *.ts file
- compile/transpile - tsc file.ts
- run node file.js
- demo variables, types, classes, interfaces, modules

## [Typescript with NPM and Webpack](https://webpack.js.org/guides/typescript/#basic-setup)
- what is [webpack](https://webpack.js.org/concepts/)

## Demo
- https://nodesource.com/blog/an-absolute-beginners-guide-to-using-npm/

- `npm init` -> get package.json
```
package.json
  version (npm registry npmjs.org)  
``` 
- `npm install --save-dev typescript` in project folder -> create the node modules
- `npm install --save-dev webpack webpack-cli` -> t get node_modules folder for webpack dependencies
- `npm install http-server`
- https://webpack.js.org/guides/printable/#guides
- semantics versioning semver versioning for `<major>.<minor>.<patch>`
- `tsc --init` -> to generate tsconfig 
    ```
        "target": "es6",                          
        "module": "commonjs",                     
        "lib": [
          "dom",
          "es6"
        ],   
        "outDir": "./out",           
        "rootDir": "./src", 
        "inlineSourceMap": true, 
    ```
- create a `src` folder and add all .ts files and .htmls as well
- run `npx webpack`- which will take our script at `src/index.js` as the entry point, and will generate `dist/main.js` as the output. 
-   In package.json add scripts:
```
   "start": "http-server dist/",
   "build": "tsc && webpack && copy src\\index.html dist",
```
- `npm run build`
- `npm start`
//package.json->developers dependency but not version depency
//package.lock-json->exact version which is required