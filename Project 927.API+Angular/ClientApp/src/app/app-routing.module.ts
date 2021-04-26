import { NgModule, Component } from '@angular/core';
import { Routes, RouterModule, CanActivate } from '@angular/router';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { LoginComponent } from './auth/Login/Login.component';
import { RegisterComponent } from './auth/Register/Register.component';
import { AdminGuard } from './Guards/admin.guard';
import { NotLoggedInGuard } from './Guards/notLoggedIn.guard';
import { UserGuard } from './Guards/user.guard';
import { HomeComponent } from './home/home.component';
import { UserProfileComponent } from './user-profile/user-profile.component';

const routes: Routes = [
    { path: '', component: HomeComponent, pathMatch: 'full' },
    { path: 'login', pathMatch: 'full', canActivate:[NotLoggedInGuard], component: LoginComponent },
    { path: 'register', pathMatch: 'full', canActivate:[NotLoggedInGuard], component: RegisterComponent },
    { path: 'admin-panel', pathMatch: 'full', canActivate: [AdminGuard], component: AdminPanelComponent },
    { path: 'user-profile', pathMatch: 'full', canActivate:[UserGuard], component: UserProfileComponent },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})

export class AppRoutingModule { }