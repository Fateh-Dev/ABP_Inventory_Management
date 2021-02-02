import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from './material-module';
import { EnumerationComponent } from './enumeration/enumeration.component';
import { I18nModule } from './i18n/i18n.module';

@NgModule({
  declarations: [AppComponent, EnumerationComponent],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    I18nModule,
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule {}
