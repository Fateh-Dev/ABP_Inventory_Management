import { HttpClient } from '@angular/common/http';
import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Project Title';
  direction: any;
  showNavigation = true;
  panelOpenState = true;
  // tslint:disable-next-line: max-line-length
  constructor(
    private ref: ChangeDetectorRef,private http: HttpClient
  ) {}
  // tslint:disable-next-line: typedef
  openDrawer() {
    this.panelOpenState = !this.panelOpenState;
  }
  changeDirection(dir: string) {
    this.direction = dir;
    this.ref.detectChanges();
  }
  showNav() {
    this.showNavigation = false;
  }
  
  ngOnInit() {
    
  }
}
