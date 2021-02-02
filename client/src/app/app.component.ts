import { HttpClient } from '@angular/common/http';
import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { TranslateService } from '@ngx-translate/core';

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
  constructor(public translate: TranslateService,
    private ref: ChangeDetectorRef,private http: HttpClient
  ) {}
  // tslint:disable-next-line: typedef
  openDrawer() {
    this.panelOpenState = !this.panelOpenState;
  }
  changeDirection(dir: string,language:string) {
    this.translate.use(language);
    this.direction = dir;
    this.ref.detectChanges();
  }
  showNav() {
    this.showNavigation = false;
  }
  
  ngOnInit() {
    
  }
}
