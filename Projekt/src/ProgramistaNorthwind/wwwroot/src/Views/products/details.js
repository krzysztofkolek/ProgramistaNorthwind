import {inject} from 'aurelia-framework';   
import {ApiDataDownloader} from "../../Service/ApiDataDownloader";

@inject(ApiDataDownloader)
export class ProductsDetails {
    constructor(downloader) {
        this.downloader = downloader;
    } 

    activate(params) {
        return this.downloader
                   .setApiUrl('/products')
                   .getById(params.id)
                   .then(employees => {
                       this.employees = employees;
                   });		
    }
}