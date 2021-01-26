$(function () {

    var l = abp.localization.getResource('Saas');

    var service = dyabp.saas.saasTenant;
    var createModal = new abp.ModalManager(abp.appPath + 'Saas/Dyabp/Saas/SaasTenant/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'Saas/Dyabp/Saas/SaasTenant/EditModal');

    var dataTable = $('#SaasTenantTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                visible: abp.auth.isGranted('Saas.SaasTenant.Update'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                visible: abp.auth.isGranted('Saas.SaasTenant.Delete'),
                                confirmMessage: function (data) {
                                    return l('SaasTenantDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('SaasTenantName'),
                data: "name"
            },
            {
                title: l('SaasTenantEditionId'),
                data: "editionId"
            },
            {
                title: l('SaasTenantConnectionStrings'),
                data: "connectionStrings"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewSaasTenantButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
