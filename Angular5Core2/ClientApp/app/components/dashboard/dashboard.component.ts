import {Component, Inject, OnInit} from '@angular/core';
import {Http} from "@angular/http";

@Component({
  selector: 'dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent implements OnInit {

    public products: Product[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Dashboard/Products').subscribe(result => {
            this.products = result.json() as Product[];
        }, error => console.error(error));
    }

  ngOnInit() {
  }

}
interface Product {
    name: string;
    type: string;
    quantity: number;
}
