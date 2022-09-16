import { Component, OnInit } from '@angular/core';
import { propertyAdd } from '../models/propertyAdd';
const url = 'assets/js/mymain.js';
@Component({
  selector: 'app-index',
  templateUrl: './index.component.html',
  styleUrls: ['./index.component.css']
})
export class IndexComponent implements OnInit {

  constructor() { }
  searchListResult: propertyAdd[] = [];;
  ngOnInit(): void {
    this.loadScript();
  }
  public loadScript() {
    let node = document.createElement('script');
    node.src = url;
    node.type = 'text/javascript';
    node.async = true;
    node.charset = 'utf-8';
    document.getElementsByTagName('head')[0].appendChild(node);
}
searchResult(data: any) {
  this.searchListResult = data;

}
}
