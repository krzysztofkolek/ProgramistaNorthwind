import {inject} from 'aurelia-framework';   
import {ApiDataDownloader} from "../../Service/ApiDataDownloader";

@inject(ApiDataDownloader)
export class CustumersIndex {
    constructor(downloader) {
        this.downloader = downloader;
    } 

    activate() {
        
        return this.downloader
                   .setApiUrl('/custumers')
                   .getAll()
                   .then(custumers => {
                       this.custumers = custumers;
                   });
    }
}