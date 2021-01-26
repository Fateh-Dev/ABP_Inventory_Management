import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'InventoryManagement',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44346',
    redirectUri: baseUrl,
    clientId: 'InventoryManagement_App',
    responseType: 'code',
    scope: 'offline_access InventoryManagement',
  },
  apis: {
    default: {
      url: 'https://localhost:44346',
      rootNamespace: 'InventoryManagement',
    },
  },
} as Environment;
