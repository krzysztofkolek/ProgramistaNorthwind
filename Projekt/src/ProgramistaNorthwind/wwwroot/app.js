export class App {
    constructor() {
        this.message = "Welcome to Aurelia!";
    }

    configureRouter(config, router) {
        this.router = router;

        config.map([
			{ route:["", "home"], moduleId:"src/Views/home", title:"Home", nav:true, name:"home"}
        ]);
    }
}