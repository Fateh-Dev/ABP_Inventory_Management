import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import  {AppSettings}  from '../baseUrl';

@Component({
  selector: 'app-enumeration',
  templateUrl: './enumeration.component.html',
  styleUrls: ['./enumeration.component.scss'],
})
export class EnumerationComponent implements OnInit {
  items: any = {};
  constructor(private http: HttpClient) {}
  
  getEnums() {
    return this.http
      .get(AppSettings.API_ENDPOINT+'/api/app/enumeration')
      .subscribe((e) => (this.items = e));
  }
  ngOnInit(): void {
    this.getEnums();
  }
}
